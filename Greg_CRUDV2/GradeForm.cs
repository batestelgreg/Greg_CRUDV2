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
    public partial class GradeForm : Form 
    {
        private GregDataContext db = new GregDataContext();
        private int selectedEnrollmentId = 0;

        public GradeForm()
        {
            InitializeComponent();
            LoadData();
            ClearForm();
        }

        private void LoadData()
        {
            try
            {
                var grades = db.usp_StudentGradeReport_Get(null, null).ToList();

                dgvGrades.DataSource = null;
                dgvGrades.DataSource = grades;

                dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGrades.ScrollBars = ScrollBars.Vertical;
                dgvGrades.ReadOnly = true;
                dgvGrades.AllowUserToAddRows = false;
                dgvGrades.AllowUserToDeleteRows = false;
                dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvGrades.MultiSelect = false;
                dgvGrades.RowHeadersVisible = false;

                HideColumn("EnrollmentID");
                HideColumn("StudentID");
                HideColumn("SectionID");
                HideColumn("CourseID");

                SetHeader("StudentName", "Student Name");
                SetHeader("CourseCode", "Course");
                SetHeader("SectionCode", "Section");
                SetHeader("Midterm", "Midterm");
                SetHeader("Final", "Final");
                SetHeader("FinalGrade", "Final Grade");
                SetHeader("Remarks", "Remarks");

                dgvGrades.ClearSelection();

                if (grades.Count == 0)
                {
                    MessageBox.Show(
                        "No enrolled students found.",
                        "No Records",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load grade records.\n\n" + ex.Message,
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SetHeader(string columnName, string header)
        {
            if (dgvGrades.Columns.Contains(columnName))
            {
                dgvGrades.Columns[columnName].HeaderText = header;
            }
        }

        private void HideColumn(string columnName)
        {
            if (dgvGrades.Columns.Contains(columnName))
            {
                dgvGrades.Columns[columnName].Visible = false;
            }
        }

        private string GetCellText(DataGridViewRow row, params string[] columnNames)
        {
            foreach (string columnName in columnNames)
            {
                if (dgvGrades.Columns.Contains(columnName))
                {
                    object value = row.Cells[columnName].Value;

                    if (value != null && value != DBNull.Value)
                    {
                        return value.ToString();
                    }
                }
            }

            return "";
        }

        private decimal GetGradeValue(DataGridViewRow row, string columnName)
        {
            if (!dgvGrades.Columns.Contains(columnName))
                return 0;

            object value = row.Cells[columnName].Value;

            if (value == null || value == DBNull.Value)
                return 0;

            decimal grade = Convert.ToDecimal(value);

            return Math.Min(100, Math.Max(0, grade));
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentId <= 0)
            {
                MessageBox.Show(
                    "Please select a student from the table first.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (numMidterm.Value < 0 || numMidterm.Value > 100)
            {
                MessageBox.Show(
                    "Midterm grade must be between 0 and 100.",
                    "Invalid Grade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                numMidterm.Focus();
                return;
            }

            if (numFinal.Value < 0 || numFinal.Value > 100)
            {
                MessageBox.Show(
                    "Final grade must be between 0 and 100.",
                    "Invalid Grade",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                numFinal.Focus();
                return;
            }

            try
            {
                db.usp_Grade_Save(
                    selectedEnrollmentId,
                    numMidterm.Value,
                    numFinal.Value
                );

                MessageBox.Show(
                    "Grades successfully saved.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save grades.\n\n" + ex.Message,
                    "Grade Saving Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvGrades.Rows[e.RowIndex];

                string enrollmentId = GetCellText(row, "EnrollmentID");

                if (!int.TryParse(enrollmentId, out selectedEnrollmentId))
                {
                    selectedEnrollmentId = 0;

                    MessageBox.Show(
                        "Unable to identify the selected enrollment.",
                        "Selection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                string studentName = GetCellText(
                    row,
                    "StudentName",
                    "FullName",
                    "Student"
                );

                string courseCode = GetCellText(row, "CourseCode");
                string sectionCode = GetCellText(row, "SectionCode");

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    studentName = GetCellText(row, "FirstName") + " " +
                                  GetCellText(row, "LastName");
                    studentName = studentName.Trim();
                }

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    studentName = "Student Name Not Available";
                }

                lblSelectedStudent.Text = studentName;

                if (!string.IsNullOrWhiteSpace(courseCode))
                {
                    lblSelectedStudent.Text += " (" + courseCode;

                    if (!string.IsNullOrWhiteSpace(sectionCode))
                    {
                        lblSelectedStudent.Text += " - " + sectionCode;
                    }

                    lblSelectedStudent.Text += ")";
                }

                numMidterm.Value = GetGradeValue(row, "Midterm");
                numFinal.Value = GetGradeValue(row, "Final");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to select the enrollment record.\n\n" + ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ClearForm()
        {
            selectedEnrollmentId = 0;
            lblSelectedStudent.Text = "None";
            numMidterm.Value = 0;
            numFinal.Value = 0;

            if (dgvGrades.DataSource != null)
            {
                dgvGrades.ClearSelection();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
    }
}
