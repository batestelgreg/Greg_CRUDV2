namespace Greg_CRUDV2
{
    partial class CourseForm
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
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.numUnits = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();

            this.lblCourseCode.Location = new System.Drawing.Point(20, 20);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(80, 20);
            this.lblCourseCode.Text = "Course Code:";

            this.txtCourseCode.Location = new System.Drawing.Point(100, 20);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(150, 20);

            this.lblCourseTitle.Location = new System.Drawing.Point(20, 50);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(80, 20);
            this.lblCourseTitle.Text = "Course Title:";

            this.txtCourseTitle.Location = new System.Drawing.Point(100, 50);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(150, 20);

            this.lblUnits.Location = new System.Drawing.Point(20, 80);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(80, 20);
            this.lblUnits.Text = "Units:";

            this.numUnits.Location = new System.Drawing.Point(100, 80);
            this.numUnits.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numUnits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numUnits.Name = "numUnits";
            this.numUnits.Size = new System.Drawing.Size(150, 20);
            this.numUnits.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.btnSave.Location = new System.Drawing.Point(20, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 25);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDelete.Location = new System.Drawing.Point(100, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 25);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(180, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 25);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(270, 20);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(400, 125);
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);

            this.ClientSize = new System.Drawing.Size(690, 165);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numUnits);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
            ((System.ComponentModel.ISupportInitialize)(this.numUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.NumericUpDown numUnits;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}