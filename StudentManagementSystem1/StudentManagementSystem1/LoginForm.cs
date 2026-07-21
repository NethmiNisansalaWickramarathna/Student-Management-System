using System;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentManagementSystem1
{
    
    public partial class LoginForm : Form
    {
        // ⚡ ලොග් වුණු පරිශීලකයාගේ තත්ත්වය (Admin/Staff) මුළු සිස්ටම් එකටම මතක තබා ගැනීමට
        public static string UserRole = "Staff";
        public LoginForm()
        {
            InitializeComponent();
        }

        // 1. SHA-256 ආරක්ෂණ ක්‍රියාවලිය (Report එකේ Cryptography අවශ්‍යතාවය)
        private string ComputeSHA256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        
           private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. ADMIN කෙනෙක් ලොග් වුණොත්
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                LoginForm.UserRole = "Admin"; // Role එක Admin කියලා මතක තියාගන්නවා
                MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            // 2. STAFF කෙනෙක් ලොග් වුණොත්
            else if (txtUsername.Text == "staff" && txtPassword.Text == "staff123")
            {
                LoginForm.UserRole = "Staff"; // Role එක Staff කියලා මතක තියාගන්නවා
                MessageBox.Show("Welcome Staff Member!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}