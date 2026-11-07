namespace Greg_CRUDV2
{
    partial class EnrollmentForm
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.SuspendLayout();

            this.lblStudent.Location = new System.Drawing.Point(20, 20);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(60, 20);
            this.lblStudent.Text = "Student:";

            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.Location = new System.Drawing.Point(80, 20);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(200, 21);

            this.lblSection.Location = new System.Drawing.Point(300, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(60, 20);
            this.lblSection.Text = "Section:";

            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Location = new System.Drawing.Point(360, 20);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(150, 21);

            this.btnEnroll.Location = new System.Drawing.Point(530, 18);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(80, 25);
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);

            this.btnDrop.Location = new System.Drawing.Point(620, 18);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(80, 25);
            this.btnDrop.Text = "Drop";
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);

            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.AllowUserToDeleteRows = false;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollments.Location = new System.Drawing.Point(20, 60);
            this.dgvEnrollments.MultiSelect = false;
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(680, 250);
            this.dgvEnrollments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrollments_CellClick);

            this.ClientSize = new System.Drawing.Size(720, 330);
            this.Controls.Add(this.dgvEnrollments);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.lblStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.DataGridView dgvEnrollments;
    }
}