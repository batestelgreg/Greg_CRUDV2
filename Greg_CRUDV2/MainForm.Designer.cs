namespace Greg_CRUDV2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnEnrollment = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnStudents.Location = new System.Drawing.Point(30, 30);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(200, 40);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Student Management";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);

            this.btnCourses.Location = new System.Drawing.Point(30, 80);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(200, 40);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "Course Management";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);

            this.btnSections.Location = new System.Drawing.Point(30, 130);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(200, 40);
            this.btnSections.TabIndex = 2;
            this.btnSections.Text = "Section Management";
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);

            this.btnEnrollment.Location = new System.Drawing.Point(30, 180);
            this.btnEnrollment.Name = "btnEnrollment";
            this.btnEnrollment.Size = new System.Drawing.Size(200, 40);
            this.btnEnrollment.TabIndex = 3;
            this.btnEnrollment.Text = "Enrollment Management";
            this.btnEnrollment.UseVisualStyleBackColor = true;
            this.btnEnrollment.Click += new System.EventHandler(this.btnEnrollment_Click);

            this.btnGrades.Location = new System.Drawing.Point(30, 230);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(200, 40);
            this.btnGrades.TabIndex = 4;
            this.btnGrades.Text = "Grade Management";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);

            this.btnReports.Location = new System.Drawing.Point(30, 280);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 40);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports & Rosters";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 350);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnEnrollment);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnEnrollment;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnReports;
    }
}