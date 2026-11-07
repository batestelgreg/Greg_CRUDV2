
namespace Greg_CRUDV2
{
    partial class SectionForm
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
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtSectionCode = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.grpDays = new System.Windows.Forms.GroupBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSectionCode = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.grpDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            this.SuspendLayout();

            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(20, 23);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(46, 15);
            this.lblCourse.TabIndex = 0;
            this.lblCourse.Text = "Course";

            // cmbCourse
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(120, 20);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(185, 23);
            this.cmbCourse.TabIndex = 1;

            // lblSectionCode
            this.lblSectionCode.AutoSize = true;
            this.lblSectionCode.Location = new System.Drawing.Point(20, 56);
            this.lblSectionCode.Name = "lblSectionCode";
            this.lblSectionCode.Size = new System.Drawing.Size(78, 15);
            this.lblSectionCode.TabIndex = 2;
            this.lblSectionCode.Text = "Section Code";

            // txtSectionCode
            this.txtSectionCode.Location = new System.Drawing.Point(120, 53);
            this.txtSectionCode.Name = "txtSectionCode";
            this.txtSectionCode.Size = new System.Drawing.Size(185, 23);
            this.txtSectionCode.TabIndex = 3;

            // lblInstructor
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(20, 89);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(58, 15);
            this.lblInstructor.TabIndex = 4;
            this.lblInstructor.Text = "Instructor";

            // txtInstructor
            this.txtInstructor.Location = new System.Drawing.Point(120, 86);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(185, 23);
            this.txtInstructor.TabIndex = 5;

            // lblRoom
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(20, 122);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(39, 15);
            this.lblRoom.TabIndex = 6;
            this.lblRoom.Text = "Room";

            // txtRoom
            this.txtRoom.Location = new System.Drawing.Point(120, 119);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(185, 23);
            this.txtRoom.TabIndex = 7;

            // lblCapacity
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(20, 155);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(55, 15);
            this.lblCapacity.TabIndex = 8;
            this.lblCapacity.Text = "Capacity";

            // numCapacity
            this.numCapacity.Location = new System.Drawing.Point(120, 152);
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(185, 23);
            this.numCapacity.TabIndex = 9;
            this.numCapacity.Value = 30;

            // lblStartTime
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(20, 188);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(60, 15);
            this.lblStartTime.TabIndex = 10;
            this.lblStartTime.Text = "Start Time";

            // dtpStartTime
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Location = new System.Drawing.Point(120, 185);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(185, 23);
            this.dtpStartTime.TabIndex = 11;

            // lblEndTime
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(20, 221);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 15);
            this.lblEndTime.TabIndex = 12;
            this.lblEndTime.Text = "End Time";

            // dtpEndTime
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Location = new System.Drawing.Point(120, 218);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(185, 23);
            this.dtpEndTime.TabIndex = 13;

            // grpDays
            this.grpDays.Controls.Add(this.chkMonday);
            this.grpDays.Controls.Add(this.chkTuesday);
            this.grpDays.Controls.Add(this.chkWednesday);
            this.grpDays.Controls.Add(this.chkThursday);
            this.grpDays.Controls.Add(this.chkFriday);
            this.grpDays.Controls.Add(this.chkSaturday);
            this.grpDays.Controls.Add(this.chkSunday);
            this.grpDays.Location = new System.Drawing.Point(20, 255);
            this.grpDays.Name = "grpDays";
            this.grpDays.Size = new System.Drawing.Size(285, 130);
            this.grpDays.TabIndex = 14;
            this.grpDays.TabStop = false;
            this.grpDays.Text = "Days of the Week";

            // chkMonday
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(12, 25);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(67, 19);
            this.chkMonday.TabIndex = 0;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = true;

            // chkTuesday
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(145, 25);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(68, 19);
            this.chkTuesday.TabIndex = 1;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = true;

            // chkWednesday
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(12, 52);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(88, 19);
            this.chkWednesday.TabIndex = 2;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = true;

            // chkThursday
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(145, 52);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(74, 19);
            this.chkThursday.TabIndex = 3;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = true;

            // chkFriday
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(12, 79);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(55, 19);
            this.chkFriday.TabIndex = 4;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = true;

            // chkSaturday
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(145, 79);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(71, 19);
            this.chkSaturday.TabIndex = 5;
            this.chkSaturday.Text = "Saturday";
            this.chkSaturday.UseVisualStyleBackColor = true;

            // chkSunday
            this.chkSunday.AutoSize = true;
            this.chkSunday.Location = new System.Drawing.Point(12, 106);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(63, 19);
            this.chkSunday.TabIndex = 6;
            this.chkSunday.Text = "Sunday";
            this.chkSunday.UseVisualStyleBackColor = true;

            // dgvSections
            this.dgvSections.AllowUserToAddRows = false;
            this.dgvSections.AllowUserToDeleteRows = false;
            this.dgvSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSections.Location = new System.Drawing.Point(330, 20);
            this.dgvSections.MultiSelect = false;
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.ReadOnly = true;
            this.dgvSections.RowHeadersVisible = false;
            this.dgvSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSections.Size = new System.Drawing.Size(570, 410);
            this.dgvSections.TabIndex = 15;
            this.dgvSections.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellClick);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(20, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(120, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(220, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // SectionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 455);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSections);
            this.Controls.Add(this.grpDays);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.txtSectionCode);
            this.Controls.Add(this.lblSectionCode);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.lblCourse);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Section Management";
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.grpDays.ResumeLayout(false);
            this.grpDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtSectionCode;
        private System.Windows.Forms.TextBox txtInstructor;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.GroupBox grpDays;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSectionCode;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
    }
}
