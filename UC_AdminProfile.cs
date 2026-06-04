using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_AdminProfile : UserControl
    {
        public int AdminUserId { get; set; }

        public UC_AdminProfile()
        {
            InitializeComponent();
        }

        private void UC_AdminProfile_Load(object sender, EventArgs e)
        {
            if (AdminUserId > 0)
                LoadAdminData();
            else
                MessageBox.Show("Admin user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadAdminData()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT a.UserName, a.Email, ad.Gender, ad.Phone, ad.Address
                               FROM AdminInfo ad
                               INNER JOIN AuthenticationInfo a ON ad.UserId = a.UserId
                               WHERE ad.UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", AdminUserId) });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Admin record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = dt.Rows[0];
                txt_UserName.Text = row["UserName"].ToString();
                txt_Email.Text = row["Email"].ToString();
                cmb_Gender.SelectedItem = row["Gender"].ToString();
                txt_Phone.Text = row["Phone"].ToString();
                txt_Address.Text = row["Address"] != DBNull.Value ? row["Address"].ToString() : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (AdminUserId <= 0)
            {
                MessageBox.Show("Invalid admin session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = txt_UserName.Text.Trim();
            string gender = cmb_Gender.SelectedItem?.ToString();
            string phone = txt_Phone.Text.Trim(); 
            string address = txt_Address.Text.Trim();

            if (phone.Length != 11 || !phone.StartsWith("01") || !long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must be exactly 11 digits and start with 01.",
                    "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("User name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                string authSql = "UPDATE AuthenticationInfo SET UserName = @UserName WHERE UserId = @UserId";
                da.ExecuteDMLQuery(authSql, new SqlParameter[]
                {
                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@UserId", AdminUserId)
                });

                string adminSql = @"UPDATE AdminInfo 
                                    SET Gender = @Gender, Phone = @Phone, Address = @Address
                                    WHERE UserId = @UserId";
                da.ExecuteDMLQuery(adminSql, new SqlParameter[]
                {
                    new SqlParameter("@Gender", gender),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address),
                    new SqlParameter("@UserId", AdminUserId)
                });

                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadAdminData();
        }
    }
}