using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Greg_CRUDV2
{
    public partial class SectionForm : Form
    {
        private GregDataContext db = new GregDataContext();
        private int selectedSectionId = 0;

        public SectionForm()
        {
            InitializeComponent();

            numCapacity.Minimum = 1;
            numCapacity.Maximum = 500;

            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.ShowUpDown = true;

            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.ShowUpDown = true;

            LoadCourses();
            LoadData();
            ClearForm();
        }

        private void LoadCourses()
        {
            try
            {
                var courses = db.usp_Course_CRUD(
                    "GETALL",
                    null,
                    null,
                    null,
                    null
                ).ToList();

                cmbCourse.DataSource = courses;
                cmbCourse.DisplayMember = "CourseCode";
                cmbCourse.ValueMember = "CourseID";

                if (courses.Count > 0)
                    cmbCourse.SelectedIndex = 0;
                else
                    cmbCourse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Course Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadData()
        {
            try
            {
                var sections = (
                    from s in db.Sections
                    join c in db.Courses
                        on s.CourseID equals c.CourseID
                    select new
                    {
                        s.SectionID,
                        s.CourseID,
                        CourseCode = c.CourseCode,
                        CourseTitle = c.CourseTitle,
                        s.SectionCode,
                        InstructorName = s.InstructorName,
                        s.Room,
                        s.Capacity,
                        s.ScheduleText
                    }
                ).ToList();

                dgvSections.DataSource = null;
                dgvSections.AutoGenerateColumns = true;
                dgvSections.DataSource = sections;

                dgvSections.ReadOnly = true;
                dgvSections.AllowUserToAddRows = false;
                dgvSections.AllowUserToDeleteRows = false;
                dgvSections.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvSections.MultiSelect = false;
                dgvSections.RowHeadersVisible = false;
                dgvSections.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvSections.Columns["SectionID"].HeaderText = "Section ID";
                dgvSections.Columns["CourseID"].Visible = false;
                dgvSections.Columns["CourseCode"].HeaderText = "Course Code";
                dgvSections.Columns["CourseTitle"].HeaderText = "Course Title";
                dgvSections.Columns["SectionCode"].HeaderText = "Section Code";
                dgvSections.Columns["InstructorName"].HeaderText = "Instructor";
                dgvSections.Columns["Room"].HeaderText = "Room";
                dgvSections.Columns["Capacity"].HeaderText = "Capacity";
                dgvSections.Columns["ScheduleText"].HeaderText = "Schedule";

                dgvSections.ClearSelection();

                if (sections.Count == 0)
                {
                    MessageBox.Show(
                        "No section records found in the database.",
                        "No Records",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Section Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void RefreshData()
        {
            db.Dispose();
            db = new GregDataContext();

            LoadData();
        }

        private List<string> GetSelectedDays()
        {
            List<string> days = new List<string>();

            if (chkMonday.Checked)
                days.Add("Monday");

            if (chkTuesday.Checked)
                days.Add("Tuesday");

            if (chkWednesday.Checked)
                days.Add("Wednesday");

            if (chkThursday.Checked)
                days.Add("Thursday");

            if (chkFriday.Checked)
                days.Add("Friday");

            if (chkSaturday.Checked)
                days.Add("Saturday");

            if (chkSunday.Checked)
                days.Add("Sunday");

            return days;
        }

        private string GetScheduleText()
        {
            string startTime = dtpStartTime.Value.ToString(
                "hh:mm tt",
                CultureInfo.InvariantCulture
            );

            string endTime = dtpEndTime.Value.ToString(
                "hh:mm tt",
                CultureInfo.InvariantCulture
            );

            string days = string.Join(", ", GetSelectedDays());

            return startTime + " - " + endTime + " | " + days;
        }

        private bool LoadSchedule(string schedule)
        {
            if (string.IsNullOrWhiteSpace(schedule))
                return false;

            string[] parts = schedule.Split('|');

            if (parts.Length != 2)
                return false;

            string[] times = parts[0].Split('-');

            if (times.Length != 2)
                return false;

            DateTime startTime;
            DateTime endTime;

            if (!DateTime.TryParseExact(
                times[0].Trim(),
                "hh:mm tt",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out startTime))
            {
                return false;
            }

            if (!DateTime.TryParseExact(
                times[1].Trim(),
                "hh:mm tt",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out endTime))
            {
                return false;
            }

            dtpStartTime.Value = DateTime.Today.Add(startTime.TimeOfDay);
            dtpEndTime.Value = DateTime.Today.Add(endTime.TimeOfDay);

            string[] days = parts[1].Split(',');

            chkMonday.Checked = days.Any(d =>
                d.Trim().Equals("Monday", StringComparison.OrdinalIgnoreCase));

            chkTuesday.Checked = days.Any(d =>
                d.Trim().Equals("Tuesday", StringComparison.OrdinalIgnoreCase));

            chkWednesday.Checked = days.Any(d =>
                d.Trim().Equals("Wednesday", StringComparison.OrdinalIgnoreCase));

            chkThursday.Checked = days.Any(d =>
                d.Trim().Equals("Thursday", StringComparison.OrdinalIgnoreCase));

            chkFriday.Checked = days.Any(d =>
                d.Trim().Equals("Friday", StringComparison.OrdinalIgnoreCase));

            chkSaturday.Checked = days.Any(d =>
                d.Trim().Equals("Saturday", StringComparison.OrdinalIgnoreCase));

            chkSunday.Checked = days.Any(d =>
                d.Trim().Equals("Sunday", StringComparison.OrdinalIgnoreCase));

            return true;
        }

        private bool ValidateSchedule()
        {
            if (dtpEndTime.Value.TimeOfDay <= dtpStartTime.Value.TimeOfDay)
            {
                MessageBox.Show(
                    "End Time must be later than Start Time.",
                    "Invalid Schedule Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtpEndTime.Focus();
                return false;
            }

            if (GetSelectedDays().Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one day for the section schedule.",
                    "Missing Schedule Days",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                chkMonday.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateFields()
        {
            if (cmbCourse.SelectedIndex < 0 ||
                cmbCourse.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a Course.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbCourse.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSectionCode.Text))
            {
                MessageBox.Show(
                    "Please enter the Section Code.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSectionCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtInstructor.Text))
            {
                MessageBox.Show(
                    "Please enter the Instructor Name.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtInstructor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                MessageBox.Show(
                    "Please enter the Room.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtRoom.Focus();
                return false;
            }

            if (numCapacity.Value < 1)
            {
                MessageBox.Show(
                    "Capacity must be greater than zero.",
                    "Invalid Capacity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                numCapacity.Focus();
                return false;
            }

            return ValidateSchedule();
        }

        private bool IsDuplicateSection(int courseId, string sectionCode)
        {
            var sections = db.usp_Section_CRUD(
                "GETBYCOURSE",
                null,
                courseId,
                null,
                null,
                null,
                null,
                null
            ).ToList();

            return sections.Any(s =>
                s.SectionID != selectedSectionId &&
                string.Equals(
                    s.SectionCode == null ? "" : s.SectionCode.Trim(),
                    sectionCode.Trim(),
                    StringComparison.OrdinalIgnoreCase
                )
            );
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                int courseId = Convert.ToInt32(cmbCourse.SelectedValue);
                int capacity = Convert.ToInt32(numCapacity.Value);

                string sectionCode = txtSectionCode.Text.Trim();
                string instructor = txtInstructor.Text.Trim();
                string room = txtRoom.Text.Trim();
                string schedule = GetScheduleText();

                if (IsDuplicateSection(courseId, sectionCode))
                {
                    MessageBox.Show(
                        "This Section Code is already registered under the selected Course. Please enter a different Section Code.",
                        "Duplicate Section",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtSectionCode.Focus();
                    return;
                }

                bool isNewRecord = selectedSectionId == 0;

                if (isNewRecord)
                {
                    db.usp_Section_CRUD(
                        "INSERT",
                        null,
                        courseId,
                        sectionCode,
                        instructor,
                        room,
                        capacity,
                        schedule
                    );
                }
                else
                {
                    db.usp_Section_CRUD(
                        "UPDATE",
                        selectedSectionId,
                        courseId,
                        sectionCode,
                        instructor,
                        room,
                        capacity,
                        schedule
                    );
                }

                RefreshData();
                ClearForm();

                MessageBox.Show(
                    isNewRecord
                        ? "Section added successfully. The GridView has been updated."
                        : "Section updated successfully. The GridView has been updated.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_Course_Section"))
                {
                    MessageBox.Show(
                        "This Section Code already exists under the selected Course. Please use a different Section Code.",
                        "Duplicate Section",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtSectionCode.Focus();
                }
                else
                {
                    MessageBox.Show(
                        ex.Message,
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSectionId <= 0)
            {
                MessageBox.Show(
                    "Please select a section first.",
                    "No Section Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this section?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.usp_Section_CRUD(
                        "DELETE",
                        selectedSectionId,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null
                    );

                    RefreshData();
                    ClearForm();

                    MessageBox.Show(
                        "Section deleted successfully. The GridView has been updated.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvSections_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvSections.Rows[e.RowIndex];

                selectedSectionId = Convert.ToInt32(
                    row.Cells["SectionID"].Value
                );

                cmbCourse.SelectedValue = Convert.ToInt32(
                    row.Cells["CourseID"].Value
                );

                txtSectionCode.Text =
                    Convert.ToString(row.Cells["SectionCode"].Value);

                txtInstructor.Text =
                    Convert.ToString(row.Cells["InstructorName"].Value);

                txtRoom.Text =
                    Convert.ToString(row.Cells["Room"].Value);

                numCapacity.Value = Convert.ToDecimal(
                    row.Cells["Capacity"].Value
                );

                string schedule = "";

                if (dgvSections.Columns.Contains("ScheduleText"))
                {
                    object scheduleValue =
                        row.Cells["ScheduleText"].Value;

                    if (scheduleValue != null &&
                        scheduleValue != DBNull.Value)
                    {
                        schedule = scheduleValue.ToString();
                    }
                }

                if (!LoadSchedule(schedule))
                    ClearSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ClearSchedule()
        {
            dtpStartTime.Value = DateTime.Today.AddHours(8);
            dtpEndTime.Value = DateTime.Today.AddHours(9);

            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            chkSunday.Checked = false;
        }

        private void ClearForm()
        {
            selectedSectionId = 0;

            txtSectionCode.Clear();
            txtInstructor.Clear();
            txtRoom.Clear();

            numCapacity.Value = 30;

            ClearSchedule();

            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;
            else
                cmbCourse.SelectedIndex = -1;

            dgvSections.ClearSelection();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
    }
}