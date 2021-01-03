﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStudentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new List<Student>();

            List<Student> listName = new List<Student>();
            List<Student> listDate = new List<Student>();
            List<Student> listTest = new List<Student>();
            List<Student> listGrade = new List<Student>();
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();

            #region Main Data
            Student stusent = new Student();
            student.Add(new Student("Max", "IELTS", new DateTime(21/12/2019), 98));
            student.Add(new Student("Max", "IELTS", new DateTime(21/02/2019), 98));
            //student.Add(new Student("Max", "IELTS", "21/12/2019", 97));
            //student.Add(new Student("Ann", "TOEFL", "23/09/2018", 93));
            //student.Add(new Student("Lewis", "Cisco", "09/01/2020", 100));
            //student.Add(new Student("Kate", "SAT", "30/03/2017", 80));
            //student.Add(new Student("John", "SAT", "04/03/2019", 100));
            //student.Add(new Student("Jack", "IELTS", "21/12/2019", 80));

            foreach (var item in student)
            {
                Console.WriteLine(item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);
            }

            #endregion


            //while not valid input dates format...
            bool valid = false;
            

            #region Enter Data via console and display

            Console.WriteLine("Enter the name of the student: ");
            var fromConsName = Console.ReadLine();

            Console.WriteLine("Enter the name of the test: ");
            var fromConsTest = Console.ReadLine();

            //Console.WriteLine("Enter the date in form DD/MM/YYYY: ");
            //var fromConsDate = Console.ReadLine();

            while (!valid)
            {
                Console.WriteLine("Enter start date:");
                string dateEntered1 = Console.ReadLine();
                Console.WriteLine("Enter end date:");
                string dateEntered2 = Console.ReadLine();

                bool isvalidDate1 = DateTime.TryParse(dateEntered1, out date1);
                bool isvalidDate2 = DateTime.TryParse(dateEntered2, out date2);
                //check if date parsing was success
                if (isvalidDate1 && isvalidDate2)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Dates entered is in incorrect format!");

                }
            }

            Console.WriteLine(date1 + "\t" + date2);

            Console.WriteLine("Enter the grade from 0 to 100: ");
            var fromCons = Int32.TryParse(Console.ReadLine(), out int fromConsGrade);

            //var fromConsDate = t1.Date;
            //if(date1.Date)


            if (fromConsName != "")
            {
                listName = student.Where(c => c.Name.ToLower().Contains(fromConsName.ToLower())).ToList();  // Searching names of students
                stusent.ShowConsole(listName);
            }

            if (fromConsTest != "")
            {
                listTest = student.Where(c => c.TestName.ToLower().Contains(fromConsTest.ToLower())).ToList();  // Searching names of tests
                stusent.ShowConsole(listTest);
            }


            //if (fromConsDate != "")
            //{
                //listDate = student.Where(c => c.Date.Contains(fromConsDate.ToLower())).ToList();  // Searching dates
                //t1.ShowConsole(listDate);
            //}


            if (fromCons)
            {
                listGrade = student.Where(c => c.Grade.Equals(fromConsGrade)).ToList();   // Searching grades of students
                stusent.ShowConsole(listGrade);
            }
            else
            {
                Console.WriteLine($"Int32.TryParse could not parse '{fromConsGrade}' to an int.");
            }

            #endregion


            var l1 = listName.Union(listTest).Union(listDate).Union(listGrade);      // Unifying the searched lists

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The main sorted list");
            foreach (var item in l1)
            {
                Console.WriteLine("\t" + item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);    // Showing the list via console
            }
            Console.WriteLine();
            Console.WriteLine();

            var sortedStudent = from u in l1
                                orderby u.Name        // Couldn't separate in other class because of u.Name
                                select u;             // In my idea, it was to make an option of sorting by names, tests, or grades

            Console.WriteLine("Sorted by names of students");
            foreach (Student item in sortedStudent)
                Console.WriteLine("\t" + item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);    // Sorted by names of students

            Console.WriteLine();
            Console.WriteLine();


            var sortedStudentDes = l1.OrderByDescending(u => u.Name);
            Console.WriteLine("Sorted by names of students by descending order");
            foreach (Student item in sortedStudentDes)
                Console.WriteLine(item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);    // Sorted by names of students by descending order


            Console.WriteLine("Enter the number of the first rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());             // Entering the number of rows
            var result = l1.Take(rows);

            foreach (var item in result)
                Console.WriteLine("\t" + item.Name + " " + item.TestName + " " + item.Date + " " + item.Grade);    // Showing the first entered number of rows
            Console.ReadLine();

        }

    }

}