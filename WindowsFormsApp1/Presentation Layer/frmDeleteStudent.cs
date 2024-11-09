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
    public partial class frmDeleteStudent : Form
    {
        public frmDeleteStudent()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = edtID.Text;
            DataHandler dataHandler = new DataHandler();
            dataHandler.RemoveStudentSearch(studentID);
        }

        public void Message(string message)
        {
            MessageBox.Show(message);
        }
        public void displayData(string message)
        {
            MessageBox.Show(message);
        }
    }
}
