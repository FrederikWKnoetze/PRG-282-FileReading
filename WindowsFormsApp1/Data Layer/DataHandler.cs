using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Business_Logic_Layer;
using WindowsFormsApp1.Presentation_Layer;

namespace WindowsFormsApp1.Data_Layer
{
    public class DataHandler
    {
        public void CreateFile()
        {
            try
            {
                if (File.Exists(filePath)==true)
                {
                    if (File.ReadAllLines(filePath).Length <= 0)
                    {
                        File.Open(filePath, FileMode.OpenOrCreate);
                        File.WriteAllText(filePath, "6666,Sannie,Koen,21,Data Science\n4444,Piet,Pompies,22,Programming\n1111,Gerhared,Raugh,20,Cyber Security\n2222,Liam,Kaiser,20,Tech Support\n3333,Janie,Knoetze,24,Graphic Design");
                        
                    }
                    
                }
                else
                {
                    File.Create(filePath);
                    File.Open(filePath, FileMode.OpenOrCreate);
                    File.WriteAllText(filePath, "6666,Sannie,Koen,21,Data Science\n4444,Piet,Pompies,22,Programming\n1111,Gerhared,Raugh,20,Cyber Security\n2222,Liam,Kaiser,20,Tech Support\n3333,Janie,Knoetze,24,Graphic Design");
                    //Data Science
                    //Programming
                    //Cyber Security
                    //Tech Support
                    //Graphic Design
                }
            }
            catch (Exception ex)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private readonly string filePath = "students.txt";
        public void AddStudent(Students student)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Manually create a line with student properties separated by commas
                    string studentData = $"{student.StudentID},{student.Name},{student.Surname},{student.Age},{student.Course}";
                    writer.WriteLine(studentData);
                    frmAddStudent frmAddStudent = new frmAddStudent();
                    frmAddStudent.Message("Student added succesfully");
                }
            }
            catch (Exception ex)
            {
                frmAddStudent frmAddStudent = new frmAddStudent();
                frmAddStudent.Message(ex.Message);
            }
        }
        public void RemoveStudentSearch(string ID, DataGridView dataGridView)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath).ToList();

                // Find the student line that matches the given ID
                string studentLine = lines.FirstOrDefault(line => line.Split(',')[0] == ID);

                // Create a DataTable to hold the student data for DataGridView
                DataTable studentTable = new DataTable();
                studentTable.Columns.Add("StudentID");
                studentTable.Columns.Add("Name");
                studentTable.Columns.Add("Surname");
                studentTable.Columns.Add("Age");
                studentTable.Columns.Add("Course");

                if (studentLine != null)
                {
                    // Split the student data line by comma
                    string[] studentData = studentLine.Split(',');

                    // Create a row for the DataTable with the student data
                    DataRow row = studentTable.NewRow();
                    row["StudentID"] = studentData[0];
                    row["Name"] = studentData[1];
                    row["Surname"] = studentData[2];
                    row["Age"] = studentData[3];
                    row["Course"] = studentData[4];

                    // Add the row to the DataTable
                    studentTable.Rows.Add(row);

                    // Bind the DataTable to the DataGridView
                    dataGridView.DataSource = studentTable;
                }
                else
                {
                    // If the student is not found, show a message
                    frmDeleteStudent frmDeleteStudent = new frmDeleteStudent();
                    frmDeleteStudent.Message("No student found with the given ID.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                frmDeleteStudent frmDeleteStudent = new frmDeleteStudent();
                frmDeleteStudent.Message(ex.Message);
            }
        }
        public void DeleteStudentByID(string studentID)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath).ToList();

                // Find the line that contains the student record with the matching Student ID
                var studentLine = lines.FirstOrDefault(line => line.Split(',')[0] == studentID);

                if (studentLine != null)
                {
                    // Remove the student record from the list
                    lines.Remove(studentLine);

                    // Write the updated list back to the file
                    File.WriteAllLines(filePath, lines);

                    // Notify the user that the student record was deleted
                    MessageBox.Show("Student record deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Notify the user if the student ID was not found
                    MessageBox.Show("No student record found with the given Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during file operations
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void searchStudentUpdate(string studentID, frmUpdateStudent frmUpdateStudent)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath).ToList();

                // Find the student line that matches the given ID
                string studentLine = lines.FirstOrDefault(line => line.Split(',')[0] == studentID);

                if (studentLine != null)
                {
                    // Split the student data line by comma
                    string[] studentData = studentLine.Split(',');
                    // Call changeEDT on the passed frmUpdateStudent instance
                    frmUpdateStudent.changeEDT(studentData[0], studentData[1], studentData[2], studentData[3], studentData[4]);
                }
                else
                {
                    MessageBox.Show("No student found with the given ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateInfo(string oldStudentID, string newStudentID, string name, string surname, string age, string course)
        {
            try
            {
                // Read all lines from the file
                var lines = File.ReadAllLines(filePath).ToList();

                // Find the line with the oldStudentID and remove it
                lines.RemoveAll(line => line.Split(',')[0] == oldStudentID);

                // Create the new student data line
                string updatedStudentData = $"{newStudentID},{name},{surname},{age},{course}";

                // Add the updated line to the list
                lines.Add(updatedStudentData);

                // Write all lines back to the file
                File.WriteAllLines(filePath, lines);

                MessageBox.Show("Student information updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
               
