namespace Greg_CRUDV2
{
    partial class GradeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlGradeEntry;
        private System.Windows.Forms.Panel pnlGradeList;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.Label lblStudentTitle;
        private System.Windows.Forms.Label lblSelectedStudent;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.NumericUpDown numMidterm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.NumericUpDown numFinal;
        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.DataGridView dgvGrades;

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
            this.pnlGradeEntry = new System.Windows.Forms.Panel();
            this.pnlGradeList = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.lblSelectedStudent = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.numMidterm = new System.Windows.Forms.NumericUpDown();
            this.lblFinal = new System.Windows.Forms.Label();
            this.numFinal = new System.Windows.Forms.NumericUpDown();
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.numMidterm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();

            this.SuspendLayout();

            this.pnlGradeEntry.Location = new System.Drawing.Point(20, 20);
            this.pnlGradeEntry.Name = "pnlGradeEntry";
            this.pnlGradeEntry.Size = new System.Drawing.Size(280, 520);
            this.pnlGradeEntry.TabIndex = 0;

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(70, 13);
            this.lblFormTitle.Text = "Grade Entry";

            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Location = new System.Drawing.Point(20, 85);
            this.lblStudentTitle.Name = "lblStudentTitle";
            this.lblStudentTitle.Size = new System.Drawing.Size(47, 13);
            this.lblStudentTitle.Text = "Student:";

            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.Location = new System.Drawing.Point(80, 85);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(33, 13);
            this.lblSelectedStudent.Text = "None";

            this.lblMidterm.AutoSize = true;
            this.lblMidterm.Location = new System.Drawing.Point(20, 150);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(47, 13);
            this.lblMidterm.Text = "Midterm:";

            this.numMidterm.DecimalPlaces = 2;
            this.numMidterm.Location = new System.Drawing.Point(20, 175);
            this.numMidterm.Maximum = 100;
            this.numMidterm.Minimum = 0;
            this.numMidterm.Name = "numMidterm";
            this.numMidterm.Size = new System.Drawing.Size(220, 20);
            this.numMidterm.TabIndex = 3;

            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(20, 225);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(33, 13);
            this.lblFinal.Text = "Final:";

            this.numFinal.DecimalPlaces = 2;
            this.numFinal.Location = new System.Drawing.Point(20, 250);
            this.numFinal.Maximum = 100;
            this.numFinal.Minimum = 0;
            this.numFinal.Name = "numFinal";
            this.numFinal.Size = new System.Drawing.Size(220, 20);
            this.numFinal.TabIndex = 4;

            this.btnSaveGrade.Location = new System.Drawing.Point(20, 310);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.Size = new System.Drawing.Size(220, 30);
            this.btnSaveGrade.TabIndex = 5;
            this.btnSaveGrade.Text = "Save Grade";
            this.btnSaveGrade.UseVisualStyleBackColor = true;
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click);

            this.pnlGradeEntry.Controls.Add(this.lblFormTitle);
            this.pnlGradeEntry.Controls.Add(this.lblStudentTitle);
            this.pnlGradeEntry.Controls.Add(this.lblSelectedStudent);
            this.pnlGradeEntry.Controls.Add(this.lblMidterm);
            this.pnlGradeEntry.Controls.Add(this.numMidterm);
            this.pnlGradeEntry.Controls.Add(this.lblFinal);
            this.pnlGradeEntry.Controls.Add(this.numFinal);
            this.pnlGradeEntry.Controls.Add(this.btnSaveGrade);

            this.pnlGradeList.Location = new System.Drawing.Point(320, 20);
            this.pnlGradeList.Name = "pnlGradeList";
            this.pnlGradeList.Size = new System.Drawing.Size(880, 520);
            this.pnlGradeList.TabIndex = 1;

            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Location = new System.Drawing.Point(18, 17);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(80, 13);
            this.lblRecordsTitle.Text = "Grade Records";

            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AllowUserToResizeColumns = true;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(18, 45);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGrades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.None;
            this.dgvGrades.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dgvGrades.RowHeadersVisible = false;
            this.dgvGrades.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrades.Size = new System.Drawing.Size(840, 455);
            this.dgvGrades.TabIndex = 1;
            this.dgvGrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellClick);

            this.pnlGradeList.Controls.Add(this.lblRecordsTitle);
            this.pnlGradeList.Controls.Add(this.dgvGrades);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 560);
            this.Controls.Add(this.pnlGradeList);
            this.Controls.Add(this.pnlGradeEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Management";

            ((System.ComponentModel.ISupportInitialize)(this.numMidterm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();

            this.ResumeLayout(false);
        }
    }
}