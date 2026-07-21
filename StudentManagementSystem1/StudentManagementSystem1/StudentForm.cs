using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentManagementSystem1
{
    public partial class StudentForm : Form
        
    {
        DataTable studentTable; // Global variable එකක් ලෙස
        public StudentForm()
        {
            InitializeComponent();

            // ⚡ ෆෝම් එක හැදෙද්දීම ටේබල් හැදෙන සහ දත්ත ලෝඩ් වෙන පරණ කෝඩ් එක
            CreateStudentTable();
            CreateGradeTable();
            LoadStudentData();

            // 🔒 [THE MASTER ACCESS LOCK] 
            // ලොග් වෙලා ඉන්නේ "Staff" නම්, Designer එක මඟඇරලා කෝඩ් එකෙන්ම Delete බටන් එක ලොක් කරනවා!
            if (LoginForm.UserRole == "Staff")
            {
                btnDelete.Enabled = false;           // ❌ බටන් එක ඔබන්න බැරි වෙන්න ලොක් කරයි
                btnDelete.Text = "Locked (Staff)";   // 🔒 බටන් එක උඩ ලස්සනට ලොක් කියලා ලියවෙයි
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            CreateStudentTable();
            CreateGradeTable();
            LoadStudentData();

            // ⚡ [ROLE-BASED ACCESS] ලොග් වී ඇත්තේ Staff කෙනෙක් නම් ඩිලීට් බටන් එක ලොක් කිරීම
            if (LoginForm.UserRole == "Staff")
            {
                btnDelete.Enabled = false; // ❌ ඩිලීට් බටන් එක ඔබන්න බැරි වෙන්න ලොක් වේ
                btnDelete.Text = "Locked (Staff)"; // 🔒 බටන් එක උඩ ලස්සනට ලොක් කියලා වැටේ

                // උඹට ඕන නම් ඔන්න GPA සේව් කරන එකත් Staff ට ලොක් කරන්න පුළුවන් මෙහෙම:
                // btnCalculateGPA.Enabled = false;
            }
        }

        private void CreateStudentTable()
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Students (
                    StudentID TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    Email TEXT,
                    Contact TEXT
                );";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        private void CreateGradeTable()
        {
            string query = @"
                CREATE TABLE IF NOT EXISTS Grades (
                    StudentID TEXT PRIMARY KEY,
                    Subject1 INTEGER,
                    Subject2 INTEGER,
                    Subject3 INTEGER,
                    GPA REAL,
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE
                );";
            DatabaseHelper.ExecuteNonQuery(query);
        }

        private void LoadStudentData()
        {
            try
            {
                string query = "SELECT * FROM Students";
                // ⚡ ඩේටාබේස් එකෙන් අලුත්ම දත්ත ටික අපේ Global Table එකට ලෝඩ් කරනවා
                studentTable = DatabaseHelper.ExecuteQuery(query);

                if (studentTable != null)
                {
                    dgvStudents.DataSource = studentTable;
                    dgvStudents.Refresh(); // ⚡ Grid එක බලෙන් රිෆ්‍රෙෂ් කරනවා
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 💾 SAVE BUTTON
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("Student ID and Name are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Students (StudentID, Name, Email, Contact) VALUES (@id, @name, @email, @contact)";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@id", txtStudentID.Text),
                new SQLiteParameter("@name", txtStudentName.Text),
                new SQLiteParameter("@email", txtEmail.Text),
                new SQLiteParameter("@contact", txtContact.Text)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Student Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🆙 UPDATE BUTTON
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please select or enter a Student ID to update!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Students SET Name = @name, Email = @email, Contact = @contact WHERE StudentID = @id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@id", txtStudentID.Text),
                new SQLiteParameter("@name", txtStudentName.Text),
                new SQLiteParameter("@email", txtEmail.Text),
                new SQLiteParameter("@contact", txtContact.Text)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Student Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ❌ DELETE BUTTON
        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                if (sender is Button btn && btn.Name == "btnDelete")
                {
                    MessageBox.Show("Please enter a Student ID to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            string query = "DELETE FROM Students WHERE StudentID = @id";
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@id", txtStudentID.Text)
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Student Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ⚡ CALCULATE GPA BUTTON (පිටතින් එන වැරදි ලින්ක් ඔක්කොම වෙන් කරලා හදන තැන)
        public void btnCalculateGPA_Click(object sender, EventArgs e)
        {
            // 🛡️ [SMART FIX] Designer එකේ බටන්ස් පැටලිලා නම්, නියම බටන් එකට බලෙන් හරවා යවයි!
            if (sender is Button clickedButton)
            {
                if (clickedButton.Name == "btnSave") { btnSave_Click(sender, e); return; }
                if (clickedButton.Name == "btnUpdate") { btnUpdate_Click(sender, e); return; }
                if (clickedButton.Name == "btnDelete") { btnDelete_Click(sender, e); return; }
            }

            // මෙතන ඉඳන් තමයි ඇත්තම GPA Calculation එක වෙන්නේ
            if (string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtSubject1.Text) ||
                string.IsNullOrEmpty(txtSubject2.Text) || string.IsNullOrEmpty(txtSubject3.Text))
            {
                MessageBox.Show("Please enter Student ID and all subject marks!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int sub1 = Convert.ToInt32(txtSubject1.Text);
                int sub2 = Convert.ToInt32(txtSubject2.Text);
                int sub3 = Convert.ToInt32(txtSubject3.Text);

                double gpa1 = GetGPAValue(sub1);
                double gpa2 = GetGPAValue(sub2);
                double gpa3 = GetGPAValue(sub3);
                double finalGPA = (gpa1 + gpa2 + gpa3) / 3.0;

                lblGPAResult.Text = "Calculated GPA: " + finalGPA.ToString("0.00");

                string insertGradeQuery = @"
                    INSERT OR REPLACE INTO Grades (StudentID, Subject1, Subject2, Subject3, GPA) 
                    VALUES (@id, @s1, @s2, @s3, @gpa);";

                SQLiteParameter[] parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@id", txtStudentID.Text),
                    new SQLiteParameter("@s1", sub1),
                    new SQLiteParameter("@s2", sub2),
                    new SQLiteParameter("@s3", sub3),
                    new SQLiteParameter("@gpa", finalGPA)
                };

                DatabaseHelper.ExecuteNonQuery(insertGradeQuery, parameters);
                MessageBox.Show("Academic Analytics Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating or saving GPA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetGPAValue(int marks)
        {
            if (marks >= 75) return 4.0;
            if (marks >= 65) return 3.3;
            if (marks >= 50) return 2.0;
            return 0.0;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtStudentName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtSubject1.Clear();
            txtSubject2.Clear();
            txtSubject3.Clear();
            lblGPAResult.Text = "Calculated GPA: 0.00";
            txtStudentID.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (studentTable != null)
            {
                // ⚡ ශිෂ්‍ය ID එක හෝ නම ටයිප් කරද්දීම ලිස්ට් එක ඔටෝමැටිකලිම Filter වන සුපිරි ලොජික් එක
                DataView dv = studentTable.DefaultView;
                dv.RowFilter = string.Format("StudentID LIKE '%{0}%' OR Name LIKE '%{0}%'", txtSearch.Text.Replace("'", "''"));
                dgvStudents.DataSource = dv.ToTable();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblGPAResult_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}