using SCHOOL_MANAGEMENT_SYSTEM;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════
        //  FORM LOAD
        // ════════════════════════════════════════════════════════
        private void Enrollment_Load(object sender, EventArgs e)
        {
            ClearAllErrors();

            // ── Gender — hardcoded, works perfectly ──────────────
            cmb_Gender.Items.Clear();
            cmb_Gender.Items.Add("-- Select Gender --");
            cmb_Gender.Items.Add("Male");
            cmb_Gender.Items.Add("Female");
            cmb_Gender.Items.Add("Other");
            cmb_Gender.SelectedIndex = 0;

            // ── Department — same logic as gender, hardcoded ─────
            // DepartmentId is stored in the Tag of each item
            cmb_Department.Items.Clear();
            cmb_Department.Items.Add("-- Select Department --");
            cmb_Department.Items.Add("CS");
            cmb_Department.Items.Add("EEE");
            cmb_Department.Items.Add("BBA");
            cmb_Department.Items.Add("ARTS");
            cmb_Department.Items.Add("PME");
            cmb_Department.SelectedIndex = 0;

            // Passwords hidden
            txt_Password.UseSystemPasswordChar = true;
            txt_ConfirmPass.UseSystemPasswordChar = true;
        }

        // ════════════════════════════════════════════════════════
        //  GET DEPARTMENT ID FROM SELECTED NAME
        //  Matches DepartmentName in your Departments table
        // ════════════════════════════════════════════════════════
        private int GetDepartmentId(string deptName)
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(
                    "SELECT DepartmentId FROM Departments WHERE DepartmentName = @Name",
                    new SqlParameter[] { new SqlParameter("@Name", deptName) });

                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["DepartmentId"]);
            }
            catch { }
            return 0;
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
        //  SUBMIT ENROLLMENT
        // ════════════════════════════════════════════════════════
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            ClearAllErrors();

            // ── Collect values ──────────────────────────────────
            string userName = txt_UserName.Text.Trim();
            string email = txt_Email.Text.Trim();
            string password = txt_Password.Text;
            string confirmPass = txt_ConfirmPass.Text;
            string address = txt_Address.Text.Trim();
            string phone = txt_Phone.Text.Trim();

            // Gender — skip placeholder at index 0
            string gender = cmb_Gender.SelectedIndex > 0
                            ? cmb_Gender.SelectedItem.ToString()
                            : "";

            // Department name — skip placeholder at index 0
            string deptName = cmb_Department.SelectedIndex > 0
                              ? cmb_Department.SelectedItem.ToString()
                              : "";

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
            { lbl_err_Phone.Text = "Enter a valid BD number (e.g. 01XXXXXXXXX)."; valid = false; }

            if (string.IsNullOrWhiteSpace(deptName))
            { lbl_err_Department.Text = "Please select a department."; valid = false; }

            if (!valid) return;

            // ── Get DepartmentId from DB by name ────────────────
            int departmentId = GetDepartmentId(deptName);
            if (departmentId == 0)
            {
                lbl_err_Department.Text = "Department not found. Contact admin.";
                return;
            }

            // ── Database insert ─────────────────────────────────
            try
            {
                DataAccess da = new DataAccess();

                // Check email uniqueness
                DataTable checkDt = da.ExecuteQueryTable(
                    "SELECT COUNT(*) FROM AuthenticationInfo WHERE Email = @Email",
                    new SqlParameter[] { new SqlParameter("@Email", email) });

                if (Convert.ToInt32(checkDt.Rows[0][0]) > 0)
                {
                    lbl_err_Email.Text = "This email is already registered.";
                    return;
                }

                // Step 1: AuthenticationInfo
                // RoleId = 3 (Student), Status = 0 (Pending)
                DataTable authDt = da.ExecuteQueryTable(
                    @"INSERT INTO AuthenticationInfo
                          (UserName, Email, PasswordHash, RoleId, Status)
                      VALUES
                          (@UserName, @Email, @Pass, 3, 0);
                      SELECT SCOPE_IDENTITY();",
                    new SqlParameter[]
                    {
                        new SqlParameter("@UserName", userName),
                        new SqlParameter("@Email",    email),
                        new SqlParameter("@Pass",     password)
                    });

                int newUserId = Convert.ToInt32(authDt.Rows[0][0]);

                // Step 2: StudentInfo
                // Status = 'Pending' — Admin approves or rejects
                da.ExecuteDMLQuery(
                    @"INSERT INTO StudentInfo
                          (UserId, Gender, Phone, Address, DepartmentId, Status)
                      VALUES
                          (@UserId, @Gender, @Phone, @Address, @DeptId, 'Pending')",
                    new SqlParameter[]
                    {
                        new SqlParameter("@UserId",  newUserId),
                        new SqlParameter("@Gender",  gender),
                        new SqlParameter("@Phone",   phone),
                        new SqlParameter("@Address", string.IsNullOrWhiteSpace(address)
                                                        ? (object)DBNull.Value
                                                        : address),
                        new SqlParameter("@DeptId",  departmentId)
                    });

                // ── Success ─────────────────────────────────────
                MessageBox.Show(
                    "Your enrollment has been submitted successfully!\n\n" +
                    "Please wait for Admin approval before logging in.",
                    "Enrollment Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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
            cmb_Gender.SelectedIndex = 0;
            cmb_Department.SelectedIndex = 0;
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
            lbl_err_Department.Text = "";
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