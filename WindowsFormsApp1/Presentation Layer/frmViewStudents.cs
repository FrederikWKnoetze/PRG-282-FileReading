using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Presentation_Layer
{
    public partial class frmViewStudents : Form
    {
        private readonly string filePath = "students.txt";
        public frmViewStudents()
        {
            InitializeComponent();
            InitializeStudentTable();
            LoadData();
        }

        public DataTable studentTable;

        public void InitializeStudentTable()
        {
            studentTable = new DataTable();
            studentTable.Columns.Add("StudentID");
            studentTable.Columns.Add("Name");
            studentTable.Columns.Add("Surname");
            studentTable.Columns.Add("Age");
            studentTable.Columns.Add("Course");
        }

        public void LoadData()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(',');

                        if (values.Length > 0)
                        {
                            studentTable.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                        }
                    }
                }
                dgvViewStudents.DataSource = studentTable;
            }
            else
            {
                MessageBox.Show("File not found");
            }

            cmbCourse.Items.Add("Bcomp");
            cmbCourse.Items.Add("BIT");

            cmbCategorySortBy.Items.Add("StudentID");
            cmbCategorySortBy.Items.Add("Name");
            cmbCategorySortBy.Items.Add("Surname");
            cmbCategorySortBy.Items.Add("Age");
            cmbCategorySortBy.Items.Add("Course");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvViewStudents.DataSource;
            bs.Filter = "StudentID like '%" + txtID.Text + "%'";
            dgvViewStudents.DataSource = bs.DataSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void frmViewStudents_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvViewStudents.DataSource;
            bs.Filter = "Name like '%" + txtName.Text + "%'";
            dgvViewStudents.DataSource = bs.DataSource;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvViewStudents.DataSource;
            bs.Filter = "Surname like '%" + txtSurname.Text + "%'";
            dgvViewStudents.DataSource = bs.DataSource;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvViewStudents.DataSource;
            bs.Filter = "Age like '%" + txtAge.Text + "%'";
            dgvViewStudents.DataSource = bs.DataSource;
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvViewStudents.DataSource;
            bs.Filter = "Course like '%" + cmbCourse.SelectedItem + "%'";
            dgvViewStudents.DataSource = bs.DataSource;
        }

        private void cmbCategorySortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategorySortBy.SelectedIndex == 0 && radAscending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["StudentID"], ListSortDirection.Ascending);
            } 
            else if (cmbCategorySortBy.SelectedIndex == 0 && radDescending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["StudentID"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 1 && radAscending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Name"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 1 && radDescending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Name"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 2 && radAscending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Surname"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 2 && radDescending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Surname"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 3 && radAscending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Age"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 3 && radDescending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Age"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 4 && radAscending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Course"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 4 && radDescending.Checked)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Course"], ListSortDirection.Descending);
            }
        }

        private void radAscending_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbCategorySortBy.SelectedIndex == 0)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["StudentID"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 1)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Name"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 2)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Surname"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 3)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Age"], ListSortDirection.Ascending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 4)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Course"], ListSortDirection.Ascending);
            }
        }

        private void radDescending_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbCategorySortBy.SelectedIndex == 0)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["StudentID"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 1)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Name"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 2)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Surname"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 3)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Age"], ListSortDirection.Descending);
            }
            else if (cmbCategorySortBy.SelectedIndex == 4)
            {
                dgvViewStudents.Sort(dgvViewStudents.Columns["Course"], ListSortDirection.Descending);
            }
        }

        private void frmViewStudents_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnReporty_Click(object sender, EventArgs e)
        {
            try
            {
                string output;
                output = "Summary Report\n";
                string rowcount=dgvViewStudents.Rows.Count.ToString();
                output += $"Number of Students:{rowcount}\n";
                int avgage = 0;
                int count = 0;

                //count and break is here beacause the is 6? rows and it breaks
                foreach (DataGridViewRow row in dgvViewStudents.Rows)
                {
                    if (count==5)
                    {
                        break;
                    }
                    avgage += int.Parse(row.Cells[3].Value.ToString());
                    count++;
                }
                avgage = avgage / int.Parse(rowcount);
                output += $"Average age: {avgage.ToString()}\n";

                using (StreamWriter sr = new StreamWriter("summary.txt"))
                {
                    sr.Write(output);
                }

                MessageBox.Show("Summary saved to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
