using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Apply : Form
    {
        public Apply()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════
        //  FORM LOAD
        // ════════════════════════════════════════════════════════
        private void Apply_Load(object sender, EventArgs e)
        {
            ClearAllErrors();

            // Gender dropdown
            cmb_Gender.Items.Clear();
            cmb_Gender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cmb_Gender.SelectedIndex = -1;

            // Experience years dropdown
            cmb_Experience.Items.Clear();
            for (int i = 0; i <= 40; i++)
                cmb_Experience.Items.Add(i.ToString());
            cmb_Experience.SelectedIndex = -1;

            // Password hidden by default
            txt_Password.UseSystemPasswordChar = true;
            txt_ConfirmPass.UseSystemPasswordChar = true;
        }

        // ════════════════════════════════════════════════════════
        //  SHOW / HIDE PASSWORD TOGGLES
        // ════════════════════════════════════════════════════════
        private void btn_TogglePass_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
            btn_TogglePass.Text = txt_Password.UseSystemPasswordChar ? "Show" : "Hide";
        }

        private void btn_ToggleConfirm_Click(object sender, EventArgs e)
        {
            txt_ConfirmPass.UseSystemPasswordChar = !txt_ConfirmPass.UseSystemPasswordChar;
            btn_ToggleConfirm.Text = txt_ConfirmPass.UseSystemPasswordChar ? "Show" : "Hide";
        }

        // ════════════════════════════════════════════════════════
        //  SUBMIT APPLICATION
        // ════════════════════════════════════════════════════════
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            ClearAllErrors();

            // ── Collect values ──────────────────────────────────
            string userName = txt_UserName.Text.Trim();
            string email = txt_Email.Text.Trim();
            string password = txt_Password.Text;
            string confirmPass = txt_ConfirmPass.Text;
            string gender = cmb_Gender.SelectedItem?.ToString() ?? "";
            string phone = txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();
            string expStr = cmb_Experience.SelectedItem?.ToString() ?? "";

            bool valid = true;

            // ── Validation ──────────────────────────────────────

            if (string.IsNullOrWhiteSpace(userName))
            { lbl_err_UserName.Text = "Full name is required."; valid = false; }

            if (string.IsNullOrWhiteSpace(email))
            { lbl_err_Email.Text = "Email is required."; valid = false; }
            else if (!IsValidEmail(email))
            { lbl_err_Email.Text = "Enter a valid email address."; valid = false; }

            if (string.IsNullOrWhiteSpace(password))
            { lbl_err_Password.Text = "Password is required."; valid = false; }
            else if (password.Length < 6)
            { lbl_err_Password.Text = "Password must be at least 6 characters."; valid = false; }

            if (string.IsNullOrWhiteSpace(confirmPass))
            { lbl_err_ConfirmPass.Text = "Please confirm your password."; valid = false; }
            else if (password != confirmPass)
            { lbl_err_ConfirmPass.Text = "Passwords do not match."; valid = false; }

            if (string.IsNullOrWhiteSpace(gender))
            { lbl_err_Gender.Text = "Please select gender."; valid = false; }

            if (string.IsNullOrWhiteSpace(phone))
            { lbl_err_Phone.Text = "Phone number is required."; valid = false; }
            else if (!Regex.IsMatch(phone, @"^01[3-9]\d{8}$"))
            { lbl_err_Phone.Text = "Enter a valid BD phone number (e.g. 01XXXXXXXXX)."; valid = false; }

            if (string.IsNullOrWhiteSpace(expStr))
            { lbl_err_Experience.Text = "Please select experience years."; valid = false; }

            if (!valid) return;

            int expYears = int.Parse(expStr);

            // ── Database insert ─────────────────────────────────
            try
            {
                DataAccess da = new DataAccess();

                // Check if email already exists
                string checkSql = "SELECT COUNT(*) FROM AuthenticationInfo WHERE Email = @Email";
                SqlParameter[] checkPrms = { new SqlParameter("@Email", email) };
                var checkDt = da.ExecuteQueryTable(checkSql, checkPrms);
                int count = Convert.ToInt32(checkDt.Rows[0][0]);

                if (count > 0)
                {
                    lbl_err_Email.Text = "This email is already registered.";
                    return;
                }

                // Step 1: Insert into AuthenticationInfo
                // RoleId = 2 (Teacher), Status = false (Pending — Admin will activate)
                string authSql = @"INSERT INTO AuthenticationInfo
                                   (UserName, Email, PasswordHash, RoleId, Status)
                                   VALUES
                                   (@UserName, @Email, @Pass, 2, 0);
                                   SELECT SCOPE_IDENTITY();";

                SqlParameter[] authPrms =
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@Email",    email),
                    new SqlParameter("@Pass",     password)
                };

                var authDt = da.ExecuteQueryTable(authSql, authPrms);
                int newUserId = Convert.ToInt32(authDt.Rows[0][0]);

                // Step 2: Insert into TeacherInfo
                string teacherSql = @"INSERT INTO TeacherInfo
                                      (UserId, Gender, Phone, Address, ExperienceYears, Salary, Status)
                                      VALUES
                                      (@UserId, @Gender, @Phone, @Address, @Exp, 0.00, 'Pending')";

                SqlParameter[] teacherPrms =
                {
                    new SqlParameter("@UserId",  newUserId),
                    new SqlParameter("@Gender",  gender),
                    new SqlParameter("@Phone",   phone),
                    new SqlParameter("@Address", string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address),
                    new SqlParameter("@Exp",     expYears)
                };

                da.ExecuteDMLQuery(teacherSql, teacherPrms);

                // ── Success ─────────────────────────────────────
                MessageBox.Show(
                    "Your application has been submitted successfully!\n\n" +
                    "Please wait for Admin approval before logging in.",
                    "Application Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Go back to Home
                Home homeForm = new Home();
                homeForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════
        //  CLEAR BUTTON
        // ════════════════════════════════════════════════════════
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            txt_Email.Clear();
            txt_Password.Clear();
            txt_ConfirmPass.Clear();
            txt_Phone.Clear();
            txt_Address.Clear();
            cmb_Gender.SelectedIndex = -1;
            cmb_Experience.SelectedIndex = -1;
            txt_Password.UseSystemPasswordChar = true;
            txt_ConfirmPass.UseSystemPasswordChar = true;
            btn_TogglePass.Text = "Show";
            btn_ToggleConfirm.Text = "Show";
            ClearAllErrors();
            txt_UserName.Focus();
        }

        // ════════════════════════════════════════════════════════
        //  BACK BUTTON
        // ════════════════════════════════════════════════════════
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Close();
        }

        // ════════════════════════════════════════════════════════
        //  HELPERS
        // ════════════════════════════════════════════════════════
        private void ClearAllErrors()
        {
            lbl_err_UserName.Text = "";
            lbl_err_Email.Text = "";
            lbl_err_Password.Text = "";
            lbl_err_ConfirmPass.Text = "";
            lbl_err_Gender.Text = "";
            lbl_err_Phone.Text = "";
            lbl_err_Experience.Text = "";
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
        }
    }
}