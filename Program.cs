using System;

namespace ALBRIGHT_ASSIGNMENT_2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* MSSA CCAD 16 - CHRISTOHPER ALBRIGHT
             * WEEK 2 - 11NOV2024
             * ASSIGNMENT 2-1
             * 
             * 
             * 2-1-1:
             * Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), 
             * StudentGrade ( char ) and public properties for each data member. Instantiate the class and assign data to properties. 
             * Display the data back on console.
             */

            Student student1 = new Student(); //instantiation step

            student1.StudentID = 1234;
            student1.StudentFname = "Chris";
            student1.StudentLname = "Albright";
            student1.StudentGrade = 'C';

            Console.WriteLine("\nSTUD_ID: " + student1.StudentID + ", Name: " + student1.StudentFname + " " + student1.StudentLname + ", STUD Grade: " + student1.StudentGrade);

            Student student2 = new Student();

            student2.StudentID = 4321;
            student2.StudentFname = "Random";
            student2.StudentLname = "Student";
            student2.StudentGrade = 'A';

            Console.WriteLine("\nSTUD_ID: "+student2.StudentID+", Name: "+ student2.StudentFname+" "+ student2.StudentLname+", STUD Grade: " + student2.StudentGrade);
                            
        }

    }
    public class Student
    {
        private int _studentid; // field
        public int StudentID; //property
        
        
        private string _studentfname; //field
        public string StudentFname; //property
        

        private string _studentlname; //field
        public string StudentLname; //property
        

        private char _studentgrade; //field
        public char StudentGrade //property
        {
            get { return _studentgrade; }
            set { _studentgrade = value; }
        }
        
    }
}

