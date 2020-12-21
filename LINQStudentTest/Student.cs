using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStudentTest
{
    public class Student
    {
        public string Name { get; set; }
        public string TestName { get; set; }
        public string Date { get; set; }
        public int Grade { get; set; }

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
                Console.WriteLine(item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);
            }

        }

       
    }
}
