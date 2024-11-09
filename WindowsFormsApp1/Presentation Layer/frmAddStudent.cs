using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Business_Logic_Layer;

namespace WindowsFormsApp1.Presentation_Layer
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studentID = edtID.Text;
            string studentName = edtName.Text;
            string studentSurname = edtSurname.Text;
            int age = int.Parse(edtAge.Text);
            string studentCourse = cmbCourse.Text;

            Students test = new Students(studentID,studentName,studentSurname,age,studentCourse);
            test.ValidateStudent();
        }
        public void Message(string message)
        {
            MessageBox.Show(message);
        }
    }
}
