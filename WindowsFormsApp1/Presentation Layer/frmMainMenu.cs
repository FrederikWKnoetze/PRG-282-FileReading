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
using WindowsFormsApp1.Business_Logic_Layer;
using WindowsFormsApp1.Data_Layer;
using WindowsFormsApp1.Presentation_Layer;

namespace WindowsFormsApp1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteStudent frmDeleteStudent = new frmDeleteStudent();
            frmDeleteStudent.ShowDialog();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewStudents frmViewStudent = new frmViewStudents();
            frmViewStudent.ShowDialog();
        }
    }
}
