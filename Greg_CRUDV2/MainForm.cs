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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm f = new StudentForm();
            f.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CourseForm f = new CourseForm();
            f.ShowDialog();
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            SectionForm f = new SectionForm();
            f.ShowDialog();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            EnrollmentForm f = new EnrollmentForm();
            f.ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            GradeForm f = new GradeForm();
            f.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm();
            f.ShowDialog();
        }
    }
}