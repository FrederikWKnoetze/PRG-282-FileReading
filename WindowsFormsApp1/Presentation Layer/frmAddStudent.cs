﻿using System;
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
            test.ValidateStudent(this);
        }
        public void Message(string message)
        {
            MessageBox.Show(message);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
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
        public void IDBorder()
        {
            pnlID.BackColor = Color.Red;
        }
        public void NameBorder()
        {
            pnlName.BackColor = Color.Red;
        }
        public void SurnameBorder()
        {
            pnlSurname.BackColor = Color.Red;
        }
        public void AgeBorder()
        {
            pnlAge.BackColor = Color.Red;
        }
        public void CourseBorder()
        {
            pnlCourse.BackColor = Color.Red;
        }
    }
}
