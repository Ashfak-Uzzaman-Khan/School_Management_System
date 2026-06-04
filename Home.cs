using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

       

        // ════════════════════════════════════════════════════════
        //  NAV BUTTON CLICKS
        // ════════════════════════════════════════════════════════

        private void btn_Apply_Click(object sender, EventArgs e)
        {

            Apply page = new Apply();

            page.Show();

            this.Hide(); page.FormClosed += (s, args) => this.Show(); 

        }

        private void btn_Enrollment_Click(object sender, EventArgs e)
        {
       
            Enrollment page = new Enrollment();

            page.Show();

            this.Hide(); page.FormClosed += (s, args) => this.Show();


        }

        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login page = new Login();

            page.Show();

            this.Hide();
            page.FormClosed += (s, args) => this.Show();
        }

        private void btn_AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About Us page coming soon!", "About Us",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: new AboutUs().Show(); this.Hide();
        }

        // ════════════════════════════════════════════════════════
        //  HOVER EFFECTS
        // ════════════════════════════════════════════════════════

        private void NavBtn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btn_Login)
                btn.BackColor = Color.FromArgb(29, 78, 216);
            else
            {
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(59, 130, 246);
            }
        }

        private void NavBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btn_Login)
                btn.BackColor = Color.FromArgb(30, 58, 138);
            else
            {
                btn.ForeColor = Color.FromArgb(30, 58, 138);
                btn.BackColor = Color.Transparent;
            }
        }

        private void StatCard_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(239, 246, 255);
        }

        private void StatCard_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.White;
        }

        private void FeatureCard_MouseEnter(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null) p.BackColor = Color.FromArgb(239, 246, 255);
        }

        private void FeatureCard_MouseLeave(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p != null) p.BackColor = Color.White;
        }

        // ════════════════════════════════════════════════════════
        //  HERO CTA BUTTONS
        // ════════════════════════════════════════════════════════

        private void btn_heroApply_Click(object sender, EventArgs e)
        {
            btn_Apply_Click(sender, e);
        }

        private void btn_heroLearn_Click(object sender, EventArgs e)
        {
            btn_AboutUs_Click(sender, e);
        }

        private void lbl_projectName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_projectName_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}