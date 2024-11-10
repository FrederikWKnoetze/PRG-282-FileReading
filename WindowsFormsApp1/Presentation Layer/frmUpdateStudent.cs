using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data_Layer;

namespace WindowsFormsApp1.Presentation_Layer
{
    public partial class frmUpdateStudent : Form
    {
        public frmUpdateStudent()
        {
            InitializeComponent();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
        }
    }
}
