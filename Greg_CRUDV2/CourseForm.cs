using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Greg_CRUDV2
{
    public partial class CourseForm : Form
    {
        private GregDataContext db = new GregDataContext();
        private int selectedCourseId = 0;

        public CourseForm()
        {
            InitializeComponent();
            numUnits.Minimum = 1;
            LoadData();
            ClearForm();
        }

        private bool IsCourseCodeAlreadyUsed(string courseCode)
        {
            var courses = db.usp_Course_CRUD(
                "GETALL",
                null,
                null,
                null,
                null
            ).ToList();

            return courses.Any(c =>
                string.Equals(c.CourseCode?.Trim(), courseCode, StringComparison.OrdinalIgnoreCase) &&
                c.CourseID != selectedCourseId
            );
        }

        private bool IsCourseTitleAlreadyUsed(string courseTitle)
        {
            var courses = db.usp_Course_CRUD(
                "GETALL",
                null,
                null,
                null,
                null
            ).ToList();

            return courses.Any(c =>
                string.Equals(c.CourseTitle?.Trim(), courseTitle, StringComparison.OrdinalIgnoreCase) &&
                c.CourseID != selectedCourseId
            );
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtCourseCode.Text))
            {
                MessageBox.Show(
                    "Please enter the Course Code.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCourseCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCourseTitle.Text))
            {
                MessageBox.Show(
                    "Please enter the Course Title.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCourseTitle.Focus();
                return false;
            }

            if (numUnits.Value < 1)
            {
                MessageBox.Show(
                    "Units must be greater than zero.",
                    "Invalid Units",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                numUnits.Focus();
                return false;
            }

            return true;
        }

        private void LoadData()
        {
            try
            {
                dgvCourses.DataSource = db.usp_Course_CRUD(
                    "GETALL",
                    null,
                    null,
                    null,
                    null
                ).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                string courseCode = txtCourseCode.Text.Trim();
                string courseTitle = txtCourseTitle.Text.Trim();
                int units = Convert.ToInt32(numUnits.Value);

                if (IsCourseCodeAlreadyUsed(courseCode))
                {
                    MessageBox.Show(
                        "This course is already in use. Please input another course.",
                        "Duplicate Course Code",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtCourseCode.Focus();
                    return;
                }

                if (IsCourseTitleAlreadyUsed(courseTitle))
                {
                    MessageBox.Show(
                        "This Course title is in use. Please use another course title.",
                        "Duplicate Course Title",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtCourseTitle.Focus();
                    return;
                }

                if (selectedCourseId == 0)
                {
                    db.usp_Course_CRUD(
                        "INSERT",
                        null,
                        courseCode,
                        courseTitle,
                        units
                    );
                }
                else
                {
                    db.usp_Course_CRUD(
                        "UPDATE",
                        selectedCourseId,
                        courseCode,
                        courseTitle,
                        units
                    );
                }

                MessageBox.Show(
                    "Course information saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId <= 0)
            {
                MessageBox.Show(
                    "Please select a course first.",
                    "No Course Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this course?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    db.usp_Course_CRUD(
                        "DELETE",
                        selectedCourseId,
                        null,
                        null,
                        null
                    );

                    MessageBox.Show(
                        "Course deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearForm();
                    LoadData();
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

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

                selectedCourseId = Convert.ToInt32(
                    row.Cells["CourseID"].Value
                );

                txtCourseCode.Text =
                    row.Cells["CourseCode"].Value.ToString();

                txtCourseTitle.Text =
                    row.Cells["CourseTitle"].Value.ToString();

                numUnits.Value = Convert.ToDecimal(
                    row.Cells["Units"].Value
                );
            }
        }

        private void ClearForm()
        {
            selectedCourseId = 0;

            txtCourseCode.Clear();
            txtCourseTitle.Clear();

            numUnits.Value = 1;
        }
    }
}