using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string doAnother;
            do
            {
                Student st = new Student();
                st.FirstName = GetInput("First Name");
                st.LastName = GetInput("Last Name");
                st.Major = GetInput("Major");
                st.StudentNumber = GetInput("Student Number");
                st.Score1 = int.Parse(GetInput("Score 1"));
                st.Score2 = int.Parse(GetInput("Score 2"));
                st.Score3 = int.Parse(GetInput("Score 3"));
                students.Add(st);
                doAnother = GetInput("\nDo another (y/n)");
            } while (doAnother == "y");
            Console.WriteLine("Student Averages:");
            foreach (Student st in students)
            {
                Console.WriteLine(st.ToString());
            }
        }
        static private string GetInput(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }
    }
}
