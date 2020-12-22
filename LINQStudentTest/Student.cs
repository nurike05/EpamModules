using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStudentTest
{
    /// <summary>
    /// Constructor for the Student class
    /// ShowConsole()
    /// </summary>
    public class Student
    {
        public string Name { get; set; }        // The name of the student
        public string TestName { get; set; }    // The test name of the student
        public string Date { get; set; }        // The date
        public int Grade { get; set; }          // The grade of the test taker

        public Student()
        {
               
        }
        public Student(string name, string testName, string date, int grade)
        {
            Name = name;
            TestName = testName;
            Date = date;
            Grade = grade;
        }
        public void ShowConsole(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine("\t" + item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);
            }

        }

       
    }
}
