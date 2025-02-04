﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Data_Layer;
using WindowsFormsApp1.Presentation_Layer;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.Business_Logic_Layer
{
    public class Students
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Students(string _studentID, string _name, string _surname, int _age, string _course)
        {
            this.StudentID = _studentID;
            this.Name = _name;
            this.Surname = _surname;
            this.Age = _age;
            this.Course = _course;
        }
        public void ValidateStudent(frmAddStudent frmAddStudents)
        {
            bool IDflag = true;
            bool Nameflag = true;
            bool Surnameflag = true;
            bool Ageflag = true;
            bool Courseflag = false;
            string[] courses = { "Data Science", "Programming", "Cyber Security", "Tech Support", "Graphic Design" };
            if (StudentID.Length == 6)
            {
                for (int i = 0; i < StudentID.Length; i++)
                {
                    if (!char.IsDigit(StudentID[i])) // Check if the character is not a digit
                    {
                        frmAddStudents.IDBorder();
                        IDflag = false; // If not a digit, set the flag to false
                        break; // Exit the loop early since we already found a non-digit
                    }
                }
            }
            else
            {
                frmAddStudents.IDBorder();
                IDflag = false;
            }
            if (Name.Length >= 2)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (!char.IsLetter(Name[i]))
                    {
                        frmAddStudents.NameBorder();
                        Nameflag = false;
                        break; // Exit the loop early since we already found an invalid character
                    }
                }
            }
            else
            {
                frmAddStudents.NameBorder();
                Nameflag = false; // If the name is too short, flag it as invalid
            }

            if (Surname.Length >= 2)
            {
                for (int i = 0; i < Surname.Length; i++)
                {
                    if (!char.IsLetter(Surname[i]))
                    {
                        frmAddStudents.SurnameBorder();
                        Surnameflag = false;
                        break; // Exit the loop early since we already found an invalid character
                    }
                }
            }
            else
            {
                frmAddStudents.SurnameBorder();
                Surnameflag = false; // If the Surname is too short, flag it as invalid
            }

            if (Age < 14 || Age > 100) // Age should be between 16 and 100
            {
                frmAddStudents.AgeBorder();
                Ageflag = false;
            }
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] == Course)
                {
                    Courseflag = true;
                    break;
                }
            }
            if(Courseflag == false)
            {
                frmAddStudents.CourseBorder();
            }
            if ((Nameflag == true) && (Surnameflag == true) && (Courseflag == true) && (Ageflag == true) && (IDflag == true))
            {
                DataHandler dataHandler = new DataHandler();
                frmAddStudent frmAddStudent = new frmAddStudent();
                frmAddStudent.Message("Inserting student now");
                dataHandler.AddStudent(this);
            }
            else
            {
                frmAddStudent frmAddStudent = new frmAddStudent();
                frmAddStudent.Message("Did not insert student because info is incorrect");
            }
        }

        
    }
}
