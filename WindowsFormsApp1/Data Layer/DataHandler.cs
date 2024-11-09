using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Business_Logic_Layer;
using WindowsFormsApp1.Presentation_Layer;

namespace WindowsFormsApp1.Data_Layer
{
    public class DataHandler
    {
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
        public void RemoveStudentSearch(string ID)
        {
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();
                string studentLine = lines.FirstOrDefault(line => line.Split(',')[0] == ID);

                if (studentLine != null)
                {
                    // Return the student's info line
                    frmDeleteStudent frmDeleteStudent = new frmDeleteStudent();
                    frmDeleteStudent.Message(studentLine);
                }
                else
                {
                    // Notify if the student with the given ID is not found
                    frmDeleteStudent frmDeleteStudent = new frmDeleteStudent();
                    frmDeleteStudent.Message("No id found");
                }
            }
            catch (Exception ex)
            {
                frmDeleteStudent frmDeleteStudent = new frmDeleteStudent();
                frmDeleteStudent.Message(ex.Message);
            }
        }
    }
}
               
