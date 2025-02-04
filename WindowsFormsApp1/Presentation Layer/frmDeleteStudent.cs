﻿using System;
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
    public partial class frmDeleteStudent : Form
    {
        private readonly string filePath = "students.txt";
        public frmDeleteStudent()
        {
            InitializeComponent();
            InitializeStudentTable();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentID = edtID.Text;
            DataHandler dataHandler = new DataHandler();
            dataHandler.RemoveStudentSearch(studentID, dgvDelete);
        }

        public void Message(string message)
        {
            MessageBox.Show(message);
        }
        public void displayData(string message)
        {
            MessageBox.Show(message);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any cell is selected
            if (dgvDelete.SelectedCells.Count > 0)
            {
                // Get the selected cell (the first selected cell)
                DataGridViewCell selectedCell = dgvDelete.SelectedCells[0];

                // Get the row and column index of the selected cell
                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;

                // Confirm which cell is selected and delete its content
                string studentID = dgvDelete.Rows[rowIndex].Cells["StudentID"].Value.ToString();
                string name = dgvDelete.Rows[rowIndex].Cells["Name"].Value.ToString();
                string surname = dgvDelete.Rows[rowIndex].Cells["Surname"].Value.ToString();
                string age = dgvDelete.Rows[rowIndex].Cells["Age"].Value.ToString();
                string course = dgvDelete.Rows[rowIndex].Cells["Course"].Value.ToString();

                // Show the information in a message box
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the data for student:\n\nStudent ID: {studentID}\nName: {name} {surname}\nAge: {age}\nCourse: {course}","Confirm Deletion",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                // If the user clicks OK, delete the content of the selected cell
                if (dialogResult == DialogResult.OK)
                {
                    DataHandler dataHandler = new DataHandler();
                    dataHandler.DeleteStudentByID(studentID);
                }
                else
                {
                    // If the user clicks Cancel, do nothing and notify them
                    MessageBox.Show("The deletion has been canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // If no cell is selected, show a warning message
                MessageBox.Show("Please select a cell to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadData();
        }

        private void frmDeleteStudent_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
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
            studentTable.Clear();
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
                dgvDelete.DataSource = studentTable;
            }
            else
            {
                MessageBox.Show("File not found");
            }
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
