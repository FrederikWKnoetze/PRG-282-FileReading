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
using WindowsFormsApp1.Data_Layer;

namespace WindowsFormsApp1.Presentation_Layer
{
    public partial class frmUpdateStudent : Form
    {
        private readonly string filePath = "students.txt";
        public frmUpdateStudent()
        {
            InitializeComponent();
            InitializeStudentTable();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = edtSearchID.Text;
            DataHandler dataHandler = new DataHandler();
            dataHandler.searchStudentUpdate(studentID, this);
        }
        public void changeEDT(string studentID, string Name, string Surname, string Age, string course) 
        {
            edtID.Text = studentID;
            edtName.Text = Name;
            edtSurname.Text = Surname;
            edtAge.Text = Age;
            cmbCourse.Text = course;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            string oldID = edtSearchID.Text;
            string newID = edtSearchID.Text;
            string Name = edtName.Text;
            string Surname = edtSurname.Text;
            string Age = edtAge.Text;
            string Course = cmbCourse.Text;
            dataHandler.updateInfo(oldID, newID, Name, Surname, Age, Course);
        }

        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmUpdateStudent_FormClosing(object sender, FormClosingEventArgs e)
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
                dgvUpdate.DataSource = studentTable;
            }
            else
            {
                MessageBox.Show("File not found");
            }

            cmbCourse.Items.Add("Bcomp");
            cmbCourse.Items.Add("BIT");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
        }
    }
}
