using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Forgot_Reset_Pass : Form
    {
        public Forgot_Reset_Pass()
        {
            InitializeComponent();
        }

        private void Forgot_Reset_Pass_Load(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            pnl_passwordResult.Visible = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            pnl_passwordResult.Visible = false;

            string username = txt_UserName.Text.Trim();
            string email = txt_Email.Text.Trim();
            string phone = txt_Phone.Text.Trim();

            // Basic validation
            if (string.IsNullOrWhiteSpace(username))
            {
                lbl_error.Text = "Please enter your username.";
                txt_UserName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                lbl_error.Text = "Please enter your email.";
                txt_Email.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                lbl_error.Text = "Please enter your phone number.";
                txt_Phone.Focus();
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                // 1. Check AuthenticationInfo by username and email
                string authSql = @"SELECT UserId, PasswordHash, RoleId 
                                   FROM AuthenticationInfo 
                                   WHERE UserName = @UserName AND Email = @Email";

                SqlParameter[] authParams = {
                    new SqlParameter("@UserName", username),
                    new SqlParameter("@Email", email)
                };

                DataTable dtAuth = da.ExecuteQueryTable(authSql, authParams);

                if (dtAuth.Rows.Count == 0)
                {
                    lbl_error.Text = "No user found with these credentials.";
                    return;
                }

                int userId = Convert.ToInt32(dtAuth.Rows[0]["UserId"]);
                int roleId = Convert.ToInt32(dtAuth.Rows[0]["RoleId"]);
                string password = dtAuth.Rows[0]["PasswordHash"].ToString();

                // 2. Verify phone number from the appropriate table
                bool phoneMatch = false;
                string phoneSql = "";
                switch (roleId)
                {
                    case 1: // Admin
                        phoneSql = "SELECT COUNT(*) FROM AdminInfo WHERE UserId = @UserId AND Phone = @Phone";
                        break;
                    case 2: // Teacher
                        phoneSql = "SELECT COUNT(*) FROM TeacherInfo WHERE UserId = @UserId AND Phone = @Phone";
                        break;
                    case 3: // Student
                        phoneSql = "SELECT COUNT(*) FROM StudentInfo WHERE UserId = @UserId AND Phone = @Phone";
                        break;
                }

                SqlParameter[] phoneParams = {
                    new SqlParameter("@UserId", userId),
                    new SqlParameter("@Phone", phone)
                };

                DataTable dtPhone = da.ExecuteQueryTable(phoneSql, phoneParams);
                int matchCount = Convert.ToInt32(dtPhone.Rows[0][0]);

                if (matchCount == 0)
                {
                    lbl_error.Text = "No user found with these credentials.";
                    return;
                }

                // 3. Success: display password dynamically
                lbl_passwordDisplay.Text = password;
                pnl_passwordResult.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Go back to Login, close this form
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}