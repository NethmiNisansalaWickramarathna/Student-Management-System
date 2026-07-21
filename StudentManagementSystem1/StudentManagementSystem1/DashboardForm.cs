using System;
using System.Windows.Forms;

namespace StudentManagementSystem1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateDashboardSummary();
        }

        // ⚡ MANAGE STUDENTS බටන් එක ඔබද්දී පිරිසිදුවට ශිෂ්‍ය ෆෝම් එක ඕපන් කරන තැන
        private void btnMenuStudents_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void UpdateDashboardSummary()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Students";
                System.Data.DataTable dt = DatabaseHelper.ExecuteQuery(query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    lblTotalStudents.Text = "Total Registered Students: " + dt.Rows[0][0].ToString();
                }
            }
            catch
            {
                lblTotalStudents.Text = "Total Registered Students: 0";
            }
        }

        private void btnMenuLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // =======================================================================
        // 🛡️ [THE EMERGENCY PATCH] - ඩිසයිනර් එකේ තිබ්බ ලෙඩ 3ම සදහටම නැති කරන කොටස
        // =======================================================================

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // හිස්ව තබන්න - ඩිසයිනර් එකේ Error එක නිවීමට පමණි
        }

        private void lblTotalStudents_Click(object sender, EventArgs e)
        {
            // හිස්ව තබන්න - ඩිසයිනර් එකේ Error එක නිවීමට පමණි
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // හිස්ව තබන්න - ඩිසයිනර් එකේ Error එක නිවීමට පමණි
        }
    }
}