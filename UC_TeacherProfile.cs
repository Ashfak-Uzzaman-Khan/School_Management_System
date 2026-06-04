using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class UC_TeacherProfile : UserControl
    {
        public int TeacherUserId { get; set; }

        public UC_TeacherProfile()
        {
            InitializeComponent();
        }

        private void UC_TeacherProfile_Load(object sender, EventArgs e)
        {
            if (TeacherUserId > 0)
                LoadTeacherData();
            else
                MessageBox.Show("Teacher user ID not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadTeacherData()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = @"SELECT a.UserName, a.Email, t.Gender, t.Phone, t.Address,
                               t.ExperienceYears, t.Salary, t.Status
                               FROM TeacherInfo t
                               INNER JOIN AuthenticationInfo a ON t.UserId = a.UserId
                               WHERE t.UserId = @UserId";
                DataTable dt = da.ExecuteQueryTable(sql,
                    new SqlParameter[] { new SqlParameter("@UserId", TeacherUserId) });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Teacher record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = dt.Rows[0];
                txt_UserName.Text = row["UserName"].ToString();
                txt_Email.Text = row["Email"].ToString();
                cmb_Gender.SelectedItem = row["Gender"].ToString();
                txt_Phone.Text = row["Phone"].ToString();
                txt_Address.Text = row["Address"] != DBNull.Value ? row["Address"].ToString() : "";
                lbl_expValue.Text = row["ExperienceYears"].ToString();
                lbl_salaryValue.Text = Convert.ToDecimal(row["Salary"]).ToString("N2");
                lbl_statusValue.Text = row["Status"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (TeacherUserId <= 0)
            {
                MessageBox.Show("Invalid teacher session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = txt_UserName.Text.Trim();
            string gender = cmb_Gender.SelectedItem?.ToString();
            string phone = txt_Phone.Text.Trim();
            string address = txt_Address.Text.Trim();

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
                    new SqlParameter("@UserId", TeacherUserId)
                });

                string teacherSql = @"UPDATE TeacherInfo 
                                      SET Gender = @Gender, Phone = @Phone, Address = @Address
                                      WHERE UserId = @UserId";
                da.ExecuteDMLQuery(teacherSql, new SqlParameter[]
                {
                    new SqlParameter("@Gender", gender),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Address", string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address),
                    new SqlParameter("@UserId", TeacherUserId)
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
            LoadTeacherData();
        }
    }
}