using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Login : Form
    {
        private bool _passVisible = false;

        // Placeholder texts
        private const string EMAIL_PLACEHOLDER = "Enter your email address";
        private const string PASS_PLACEHOLDER = "Enter your password";

        public Login()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════
        //  FORM LOAD
        // ════════════════════════════════════════════════════════
        private void Login_Load(object sender, EventArgs e)
        {
            lbl_emailError.Text = "";
            lbl_passError.Text = "";

            // Set placeholder manually for .NET Framework
            SetPlaceholder(txt_Email, EMAIL_PLACEHOLDER);
            SetPlaceholder(txt_Password, PASS_PLACEHOLDER);
        }

        // ════════════════════════════════════════════════════════
        //  PLACEHOLDER HELPERS (.NET Framework compatible)
        // ════════════════════════════════════════════════════════
        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            tb.ForeColor = Color.FromArgb(148, 163, 184);
            tb.Text = placeholder;
            if (tb == txt_Password)
                tb.UseSystemPasswordChar = false;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.FromArgb(30, 41, 59);
                    if (tb == txt_Password && !_passVisible)
                        tb.UseSystemPasswordChar = true;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.ForeColor = Color.FromArgb(148, 163, 184);
                    tb.Text = placeholder;
                    if (tb == txt_Password)
                        tb.UseSystemPasswordChar = false;
                }
            };
        }

        private string GetTextBoxValue(TextBox tb, string placeholder)
        {
            return tb.Text == placeholder ? "" : tb.Text;
        }

        // ════════════════════════════════════════════════════════
        //  SHOW / HIDE PASSWORD
        // ════════════════════════════════════════════════════════
        private void btn_TogglePass_Click(object sender, EventArgs e)
        {
            string current = GetTextBoxValue(txt_Password, PASS_PLACEHOLDER);
            if (string.IsNullOrEmpty(current)) return;

            _passVisible = !_passVisible;
            txt_Password.UseSystemPasswordChar = !_passVisible;
            btn_TogglePass.Text = _passVisible ? "Hide" : "Show";
        }

        // ════════════════════════════════════════════════════════
        //  LOGIN BUTTON
        // ════════════════════════════════════════════════════════
        private void btn_Login_Click(object sender, EventArgs e)
        {
            lbl_emailError.Text = "";
            lbl_passError.Text = "";

            string email = GetTextBoxValue(txt_Email, EMAIL_PLACEHOLDER).Trim();
            string password = GetTextBoxValue(txt_Password, PASS_PLACEHOLDER);

            // ── Validation ─────────────────────────────────────
            if (string.IsNullOrWhiteSpace(email))
            {
                lbl_emailError.Text = "Please enter your email.";
                txt_Email.Focus();
                return;
            }

            if (!IsValidEmail(email))
            {
                lbl_emailError.Text = "Please enter a valid email address.";
                txt_Email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lbl_passError.Text = "Please enter your password.";
                txt_Password.Focus();
                return;
            }

            // ── Database check ─────────────────────────────────
            try
            {
                DataAccess da = new DataAccess();

                // Step 1: Check email exists
                string sql = "SELECT UserId, UserName, PasswordHash, RoleId, Status " +
                             "FROM AuthenticationInfo WHERE Email = @Email";

                SqlParameter[] prms =
                {
                    new SqlParameter("@Email", email)
                };

                DataTable dt = da.ExecuteQueryTable(sql, prms);

                if (dt.Rows.Count == 0)
                {
                    lbl_emailError.Text = "No account found with this email.";
                    txt_Email.Focus();
                    return;
                }

                DataRow row = dt.Rows[0];
                string dbHash = row["PasswordHash"].ToString();
                int roleId = Convert.ToInt32(row["RoleId"]);
                bool status = Convert.ToBoolean(row["Status"]);

                // Step 2: Account active?
                if (!status)
                {
                    MessageBox.Show(
                        "Your account is inactive.\nPlease contact the administrator.",
                        "Account Inactive",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Step 3: Password check
                if (!VerifyPassword(password, dbHash))
                {
                    lbl_passError.Text = "Incorrect password. Please try again.";
                    txt_Password.Text = "";
                    SetPlaceholder(txt_Password, PASS_PLACEHOLDER);
                    txt_Password.Focus();
                    return;
                }

                // Step 4: Route by role
                this.Hide();

                switch (roleId)
                {
                    /*
                     * case 1: // Admin
                        string adminUserName = row["UserName"].ToString();
                        AdminDashboard adminForm = new AdminDashboard();
                        adminForm.UserName = adminUserName;
                        adminForm.FormClosed += (s, args) => this.Show();
                        adminForm.Show();
                        break;
                    */
                    case 1: // Admin
                        string adminUserName = row["UserName"].ToString();
                        int adminUserId = Convert.ToInt32(row["UserId"]);
                        AdminDashboard adminForm = new AdminDashboard();
                        adminForm.UserName = adminUserName;
                        adminForm.UserId = adminUserId;
                        adminForm.FormClosed += (s, args) => this.Show();
                        adminForm.Show();
                        break;

                    case 2: // Teacher
                        string teacherUserName = row["UserName"].ToString();
                        int teacherUserId = Convert.ToInt32(row["UserId"]);
                        TeacherDashboard teacherForm = new TeacherDashboard();
                        teacherForm.UserName = teacherUserName;
                        teacherForm.UserId = teacherUserId;
                        teacherForm.FormClosed += (s, args) => this.Show();
                        teacherForm.Show();
                        break;

                    case 3: // Student
                        string studentUserName = row["UserName"].ToString();
                        int studentUserId = Convert.ToInt32(row["UserId"]);
                        StudentDashboard studentForm = new StudentDashboard();
                        studentForm.UserName = studentUserName;
                        studentForm.UserId = studentUserId;
                        studentForm.FormClosed += (s, args) => this.Show();
                        studentForm.Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role. Contact administrator.",
                            "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════
        //  FORGOT PASSWORD
        // ════════════════════════════════════════════════════════
        private void lnk_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Reset_Pass forgotForm = new Forgot_Reset_Pass();
            forgotForm.FormClosed += (s, args) =>
            {
                this.Show();
                this.BringToFront();
                lbl_emailError.Text = "";
                lbl_passError.Text = "";
                SetPlaceholder(txt_Email, EMAIL_PLACEHOLDER);
                SetPlaceholder(txt_Password, PASS_PLACEHOLDER);
            };
            this.Hide();
            forgotForm.Show();
        }

        // ════════════════════════════════════════════════════════
        //  BACK TO HOME
        // ════════════════════════════════════════════════════════
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Close();
        }

        // ════════════════════════════════════════════════════════
        //  CLEAR
        // ════════════════════════════════════════════════════════
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_emailError.Text = "";
            lbl_passError.Text = "";
            SetPlaceholder(txt_Email, EMAIL_PLACEHOLDER);
            SetPlaceholder(txt_Password, PASS_PLACEHOLDER);
            txt_Email.Focus();
        }

        // ════════════════════════════════════════════════════════
        //  ENTER KEY
        // ════════════════════════════════════════════════════════
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Login_Click(sender, e);
        }

        private void txt_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Password.Focus();
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            string val = GetTextBoxValue(txt_Email, EMAIL_PLACEHOLDER).Trim();
            if (!string.IsNullOrWhiteSpace(val) && !IsValidEmail(val))
                lbl_emailError.Text = "Please enter a valid email address.";
            else
                lbl_emailError.Text = "";
        }

        // ════════════════════════════════════════════════════════
        //  HELPERS
        // ════════════════════════════════════════════════════════
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
        }

        // SHA-256 password verification
        // যদি DB তে plain text থাকে তাহলে এটা বদলান:
        // private bool VerifyPassword(string input, string stored) => input == stored;
        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                // DB তে plain text password আছে — সরাসরি compare
                return inputPassword.Trim() == storedHash.Trim();
            }
        }
    }
}