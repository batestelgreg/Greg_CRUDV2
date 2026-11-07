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
    public partial class EnrollmentForm : Form
    {
        private GregDataContext db = new GregDataContext();
        private int selectedEnrollmentId = 0;

        public EnrollmentForm()
        {
            InitializeComponent();
            LoadDropdowns();
            LoadEnrollments();
        }

        private void LoadDropdowns()
        {
            try
            {

                var students = db.usp_Student_CRUD(
                    "SEARCH",
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null
                ).ToList();

                cmbStudent.DataSource = null;
                cmbStudent.DisplayMember = "LastName";
                cmbStudent.ValueMember = "StudentID";
                cmbStudent.DataSource = students;
                var sections = (
                    from s in db.Sections
                    join c in db.Courses
                        on s.CourseID equals c.CourseID
                    select new
                    {
                        s.SectionID,
                        s.SectionCode,
                        c.CourseCode,
                        SectionDisplay = c.CourseCode + " - " + s.SectionCode
                    }
                ).ToList();

                cmbSection.DataSource = null;
                cmbSection.DisplayMember = "SectionDisplay";
                cmbSection.ValueMember = "SectionID";
                cmbSection.DataSource = sections;

                if (cmbSection.Items.Count > 0)
                {
                    cmbSection.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(
                        "No section records found. Please add sections in Section Management first.",
                        "No Sections",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Dropdown Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadEnrollments()
        {
            try
            {
                dgvEnrollments.DataSource =
                    db.usp_StudentGradeReport_Get(null, null).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Enrollment Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedValue == null ||
                    cmbSection.SelectedValue == null)
                {
                    MessageBox.Show("Please select a student and section.");
                    return;
                }

                int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
                int sectionId = Convert.ToInt32(cmbSection.SelectedValue);

                db.usp_Enrollment_Create(studentId, sectionId);

                LoadEnrollments();

                MessageBox.Show(
                    "Student successfully enrolled.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Enrollment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentId <= 0)
            {
                MessageBox.Show("Please select an enrollment first.");
                return;
            }

            try
            {
                db.usp_Enrollment_Drop(selectedEnrollmentId);

                selectedEnrollmentId = 0;

                LoadEnrollments();

                MessageBox.Show(
                    "Enrollment successfully dropped.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Drop Enrollment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];

                selectedEnrollmentId = Convert.ToInt32(
                    row.Cells["EnrollmentID"].Value
                );
            }
        }
    }
}