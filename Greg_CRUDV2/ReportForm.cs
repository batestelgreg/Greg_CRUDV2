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
    public partial class ReportForm : Form
    {
        private GregDataContext db = new GregDataContext();

        public ReportForm()
        {
            InitializeComponent();
            LoadFilters();
            LoadReport();
        }

        private void LoadFilters()
        {
            try
            {
                var students = db.usp_Student_CRUD(
                    "SEARCH", null, null, null, null,
                    null, null, null, null, null
                ).ToList();

                cmbStudentFilter.DataSource = students.Select(s => new
                {
                    s.StudentID,
                    FullName = s.LastName + ", " + s.FirstName +
                        (string.IsNullOrWhiteSpace(s.MiddleName)
                            ? ""
                            : " " + s.MiddleName)
                }).ToList();

                cmbStudentFilter.DisplayMember = "FullName";
                cmbStudentFilter.ValueMember = "StudentID";
                cmbStudentFilter.SelectedIndex = -1;

                var sections = db.Sections
                    .Join(db.Courses,
                        s => s.CourseID,
                        c => c.CourseID,
                        (s, c) => new
                        {
                            s.SectionID,
                            SectionDisplay = c.CourseCode + " - " + s.SectionCode
                        })
                    .ToList();

                cmbSectionFilter.DataSource = sections;
                cmbSectionFilter.DisplayMember = "SectionDisplay";
                cmbSectionFilter.ValueMember = "SectionID";
                cmbSectionFilter.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Filter Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LoadReport(int? studentId = null, int? sectionId = null)
        {
            try
            {
                dgvReport.DataSource = db.usp_StudentGradeReport_Get(
                    studentId,
                    sectionId
                ).ToList();

                dgvReport.ReadOnly = true;
                dgvReport.AllowUserToAddRows = false;
                dgvReport.AllowUserToDeleteRows = false;
                dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReport.MultiSelect = false;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReport.ScrollBars = ScrollBars.Vertical;
                dgvReport.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Report Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnFilterStudent_Click(object sender, EventArgs e)
        {
            if (cmbStudentFilter.SelectedValue == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            LoadReport(Convert.ToInt32(cmbStudentFilter.SelectedValue));
        }

        private void btnFilterSection_Click(object sender, EventArgs e)
        {
            if (cmbSectionFilter.SelectedValue == null)
            {
                MessageBox.Show("Please select a section.");
                return;
            }

            LoadReport(null, Convert.ToInt32(cmbSectionFilter.SelectedValue));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbStudentFilter.SelectedIndex = -1;
            cmbSectionFilter.SelectedIndex = -1;
            LoadReport();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
    }
}
