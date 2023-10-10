using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Student
    {
        //-------------------------------------
        //Private Fields
        //-------------------------------------
        private int score1;
        private int score2;
        private int score3;

        // -------------------------------------
        // Properties
        // -------------------------------------
        public int Score1
        {
            get { return score1; }
            set { score1 = value; CalcAverage(); }
        }

        public int Score2
        {
            get { return score2; }
            set { score2 = value; CalcAverage(); }
        }

        public int Score3
        {
            get { return score3; }
            set { score3 = value; CalcAverage(); }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; private set; }
        //-------------------------------------
        //Constructors
        //-------------------------------------

        //default constructor
        public Student()
            : this("Number Pending", "TBD", "TBD", "Undeclared")
        {
        }

        //single parameter constructor
        public Student(string sID)
            : this(sID, "TBD", "TBD", "Undeclared")
        {
        }

        //constructor when we have student ID information and major
        public Student(string sID, string firstName, string lastName, string maj)
        {
            StudentNumber = sID;
            FirstName = firstName;
            LastName = lastName;
            Major = maj;
        }

        //constructor when we have student information and score information
        public Student(string sID, string firstName, string lastName,
            int s1, int s2, int s3, string maj)
            : this(sID, firstName, lastName, maj)
        {
            score1 = s1;
            score2 = s2;
            score3 = s3;
            CalcAverage();
        }

        //-------------------------------------
        //Instance Methods
        //------------------------------------
        private void CalcAverage()
        {
            Average = score1 + score2 + score3 / 3.0;
        }

        public override string ToString()
        {
            return
             FirstName + " " + LastName
             + " Major: " + Major
             + " Average: " + Average;
        }
    }
}
