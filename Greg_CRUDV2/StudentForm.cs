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
    public partial class StudentForm : Form
    {
        private GregDataContext db = new GregDataContext();
        private int selectedStudentId = 0;

        public StudentForm()
        {
            InitializeComponent();

            cmbStatus.Items.AddRange(new object[]
            {
                "Active", "Inactive", "Graduated"
            });

            cmbYearLevel.Items.AddRange(new object[]
            {
                "1st", "2nd", "3rd", "4th"
            });

            ClearForm();
            LoadData();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            email = email.Trim();

            return System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
            );
        }

        private bool IsEmailAlreadyUsed(string email)
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

            return students.Any(s =>
                string.Equals(
                    s.Email,
                    email,
                    StringComparison.OrdinalIgnoreCase
                )
                && s.StudentID != selectedStudentId
            );
        }

        private bool IsNameAlreadyUsed(string lastName, string firstName)
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

            return students.Any(s =>
                string.Equals(s.LastName?.Trim(), lastName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(s.FirstName?.Trim(), firstName, StringComparison.OrdinalIgnoreCase) &&
                s.StudentID != selectedStudentId
            );
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
            {
                MessageBox.Show(
                    "Please enter the Student Number.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtStudentNo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show(
                    "Please enter the Last Name.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show(
                    "Please enter the First Name.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter the Email Address.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return false;
            }

            

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter a valid email address.\n\nExample: student@gmail.com",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return false;
            }

            if (cmbYearLevel.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Year Level.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbYearLevel.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Student Status.",
                    "Required Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbStatus.Focus();
                return false;
            }
            
            return true;
        }

        private void LoadData(string keyword = "")
        {
            dgvStudents.DataSource = db.usp_Student_CRUD(
                "SEARCH",
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                keyword
            ).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                string email = txtEmail.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string firstName = txtFirstName.Text.Trim();

                if (IsEmailAlreadyUsed(email))
                {
                    MessageBox.Show(
                        "This email address is already registered. Please use another email.",
                        "Duplicate Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtEmail.Focus();
                    return;
                }

                if (IsNameAlreadyUsed(lastName, firstName))
                {
                    MessageBox.Show(
                        "Name already in use. Please input another name",
                        "Duplicate Name",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtLastName.Focus();
                    return;
                }

                int year = cmbYearLevel.SelectedIndex + 1;

                if (selectedStudentId == 0)
                {
                    db.usp_Student_CRUD(
                        "INSERT",
                        null,
                        txtStudentNo.Text.Trim(),
                        lastName,
                        firstName,
                        txtMiddlename.Text.Trim(),
                        email,
                        year,
                        cmbStatus.SelectedItem.ToString(),
                        null
                    );
                }
                else
                {
                    db.usp_Student_CRUD(
                        "UPDATE",
                        selectedStudentId,
                        txtStudentNo.Text.Trim(),
                        lastName,
                        firstName,
                        txtMiddlename.Text.Trim(),
                        email,
                        year,
                        cmbStatus.SelectedItem.ToString(),
                        null
                    );
                }

                MessageBox.Show(
                    "Student information saved successfully.",
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
            if (selectedStudentId > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.usp_Student_CRUD(
                            "DELETE",
                            selectedStudentId,
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            null
                        );

                        MessageBox.Show(
                            "Student deleted successfully.",
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
            else
            {
                MessageBox.Show(
                    "Please select a student first.",
                    "No Student Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text.Trim());
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(
                    row.Cells["StudentID"].Value
                );

                txtStudentNo.Text = row.Cells["StudentNo"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();

                txtMiddlename.Text =
                    row.Cells["MiddleName"].Value == DBNull.Value
                    ? ""
                    : row.Cells["MiddleName"].Value.ToString();

                txtEmail.Text = row.Cells["Email"].Value.ToString();

                int yearVal = Convert.ToInt32(
                    row.Cells["YearLevel"].Value
                );

                if (yearVal >= 1 && yearVal <= 4)
                {
                    cmbYearLevel.SelectedIndex = yearVal - 1;
                }

                cmbStatus.SelectedItem =
                    row.Cells["StudentStatus"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            selectedStudentId = 0;

            string ticks = DateTime.Now.Ticks.ToString();
            string sixDigits = ticks.Substring(ticks.Length - 6);

            txtStudentNo.Text = "CTU-" + sixDigits;

            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddlename.Clear();
            txtEmail.Clear();

            cmbYearLevel.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

    }
}