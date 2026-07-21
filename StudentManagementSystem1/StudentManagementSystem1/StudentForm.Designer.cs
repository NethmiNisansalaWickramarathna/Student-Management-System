namespace StudentManagementSystem1
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtSubject1 = new System.Windows.Forms.TextBox();
            this.txtSubject2 = new System.Windows.Forms.TextBox();
            this.txtSubject3 = new System.Windows.Forms.TextBox();
            this.lblGPAResult = new System.Windows.Forms.Label();
            this.btnCalculateGPA = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.Location = new System.Drawing.Point(148, 18);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(148, 71);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(148, 204);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(295, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(295, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Location = new System.Drawing.Point(295, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Location = new System.Drawing.Point(295, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(401, 43);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(399, 150);
            this.dgvStudents.TabIndex = 12;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // txtSubject1
            // 
            this.txtSubject1.Location = new System.Drawing.Point(236, 280);
            this.txtSubject1.Name = "txtSubject1";
            this.txtSubject1.Size = new System.Drawing.Size(100, 20);
            this.txtSubject1.TabIndex = 13;
            // 
            // txtSubject2
            // 
            this.txtSubject2.Location = new System.Drawing.Point(236, 306);
            this.txtSubject2.Name = "txtSubject2";
            this.txtSubject2.Size = new System.Drawing.Size(100, 20);
            this.txtSubject2.TabIndex = 14;
            // 
            // txtSubject3
            // 
            this.txtSubject3.Location = new System.Drawing.Point(236, 333);
            this.txtSubject3.Name = "txtSubject3";
            this.txtSubject3.Size = new System.Drawing.Size(100, 20);
            this.txtSubject3.TabIndex = 15;
            // 
            // lblGPAResult
            // 
            this.lblGPAResult.AutoSize = true;
            this.lblGPAResult.BackColor = System.Drawing.Color.LightGray;
            this.lblGPAResult.Location = new System.Drawing.Point(54, 405);
            this.lblGPAResult.Name = "lblGPAResult";
            this.lblGPAResult.Size = new System.Drawing.Size(62, 13);
            this.lblGPAResult.TabIndex = 16;
            this.lblGPAResult.Text = "GPAResult ";
            this.lblGPAResult.Click += new System.EventHandler(this.lblGPAResult_Click);
            // 
            // btnCalculateGPA
            // 
            this.btnCalculateGPA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculateGPA.Location = new System.Drawing.Point(542, 330);
            this.btnCalculateGPA.Name = "btnCalculateGPA";
            this.btnCalculateGPA.Size = new System.Drawing.Size(194, 23);
            this.btnCalculateGPA.TabIndex = 17;
            this.btnCalculateGPA.Text = "Calculate and Save GPA";
            this.btnCalculateGPA.UseVisualStyleBackColor = false;
            this.btnCalculateGPA.Click += new System.EventHandler(this.btnCalculateGPA_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(557, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(398, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Search (ID / Name) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(30, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Business Studies :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(30, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Economics : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(30, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ICT :";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCalculateGPA);
            this.Controls.Add(this.lblGPAResult);
            this.Controls.Add(this.txtSubject3);
            this.Controls.Add(this.txtSubject2);
            this.Controls.Add(this.txtSubject1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.btnDelete_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtSubject1;
        private System.Windows.Forms.TextBox txtSubject2;
        private System.Windows.Forms.TextBox txtSubject3;
        private System.Windows.Forms.Label lblGPAResult;
        private System.Windows.Forms.Button btnCalculateGPA;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}