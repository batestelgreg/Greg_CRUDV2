namespace Greg_CRUDV2
{
    partial class ReportForm
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
            this.lblStudentFilter = new System.Windows.Forms.Label();
            this.cmbStudentFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterStudent = new System.Windows.Forms.Button();
            this.lblSectionFilter = new System.Windows.Forms.Label();
            this.cmbSectionFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterSection = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            this.lblStudentFilter.Location = new System.Drawing.Point(20, 20);
            this.lblStudentFilter.Name = "lblStudentFilter";
            this.lblStudentFilter.Size = new System.Drawing.Size(90, 20);
            this.lblStudentFilter.Text = "Student Grade:";

            this.cmbStudentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentFilter.Location = new System.Drawing.Point(110, 20);
            this.cmbStudentFilter.Name = "cmbStudentFilter";
            this.cmbStudentFilter.Size = new System.Drawing.Size(160, 21);

            this.btnFilterStudent.Location = new System.Drawing.Point(280, 18);
            this.btnFilterStudent.Name = "btnFilterStudent";
            this.btnFilterStudent.Size = new System.Drawing.Size(75, 23);
            this.btnFilterStudent.Text = "View Grade";
            this.btnFilterStudent.Click += new System.EventHandler(this.btnFilterStudent_Click);

            this.lblSectionFilter.Location = new System.Drawing.Point(380, 20);
            this.lblSectionFilter.Name = "lblSectionFilter";
            this.lblSectionFilter.Size = new System.Drawing.Size(90, 20);
            this.lblSectionFilter.Text = "Section Roster:";

            this.cmbSectionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSectionFilter.Location = new System.Drawing.Point(470, 20);
            this.cmbSectionFilter.Name = "cmbSectionFilter";
            this.cmbSectionFilter.Size = new System.Drawing.Size(160, 21);

            this.btnFilterSection.Location = new System.Drawing.Point(640, 18);
            this.btnFilterSection.Name = "btnFilterSection";
            this.btnFilterSection.Size = new System.Drawing.Size(75, 23);
            this.btnFilterSection.Text = "View Roster";
            this.btnFilterSection.Click += new System.EventHandler(this.btnFilterSection_Click);

            this.btnReset.Location = new System.Drawing.Point(730, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Text = "Show All";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(20, 60);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(785, 280);

            this.ClientSize = new System.Drawing.Size(825, 360);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilterSection);
            this.Controls.Add(this.cmbSectionFilter);
            this.Controls.Add(this.lblSectionFilter);
            this.Controls.Add(this.btnFilterStudent);
            this.Controls.Add(this.cmbStudentFilter);
            this.Controls.Add(this.lblStudentFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Report & Section Roster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblStudentFilter;
        private System.Windows.Forms.ComboBox cmbStudentFilter;
        private System.Windows.Forms.Button btnFilterStudent;
        private System.Windows.Forms.Label lblSectionFilter;
        private System.Windows.Forms.ComboBox cmbSectionFilter;
        private System.Windows.Forms.Button btnFilterSection;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}