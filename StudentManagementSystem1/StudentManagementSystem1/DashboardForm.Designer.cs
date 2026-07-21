namespace StudentManagementSystem1
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuLogout = new System.Windows.Forms.Button();
            this.btnMenuStudents = new System.Windows.Forms.Button();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMenuLogout);
            this.panel1.Controls.Add(this.btnMenuStudents);
            this.panel1.Controls.Add(this.btnMenuDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnMenuLogout
            // 
            this.btnMenuLogout.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMenuLogout.Location = new System.Drawing.Point(12, 364);
            this.btnMenuLogout.Name = "btnMenuLogout";
            this.btnMenuLogout.Size = new System.Drawing.Size(156, 23);
            this.btnMenuLogout.TabIndex = 2;
            this.btnMenuLogout.Text = "Logout";
            this.btnMenuLogout.UseVisualStyleBackColor = false;
            this.btnMenuLogout.Click += new System.EventHandler(this.btnMenuLogout_Click);
            // 
            // btnMenuStudents
            // 
            this.btnMenuStudents.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMenuStudents.Location = new System.Drawing.Point(12, 214);
            this.btnMenuStudents.Name = "btnMenuStudents";
            this.btnMenuStudents.Size = new System.Drawing.Size(156, 23);
            this.btnMenuStudents.TabIndex = 1;
            this.btnMenuStudents.Text = "Manage Students";
            this.btnMenuStudents.UseVisualStyleBackColor = false;
            this.btnMenuStudents.Click += new System.EventHandler(this.btnMenuStudents_Click);
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMenuDashboard.Location = new System.Drawing.Point(12, 58);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Size = new System.Drawing.Size(156, 23);
            this.btnMenuDashboard.TabIndex = 0;
            this.btnMenuDashboard.Text = "Dashboard";
            this.btnMenuDashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT MANAGEMENT SYSTEM - DASHBOARD";
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainContentPanel.Controls.Add(this.lblTotalStudents);
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(200, 100);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(600, 350);
            this.mainContentPanel.TabIndex = 2;
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalStudents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalStudents.Location = new System.Drawing.Point(119, 83);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(155, 25);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "Total Students : ";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuLogout;
        private System.Windows.Forms.Button btnMenuStudents;
        private System.Windows.Forms.Button btnMenuDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Label lblTotalStudents;
    }
}