using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        public class Student
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Hometown { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName} is {Age} years old.";
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] studentData = input.Split();

                Student student = new Student
                {
                    FirstName = studentData[0],
                    LastName = studentData[1],
                    Age = int.Parse(studentData[2]),
                    Hometown = studentData[3]
                };

                students.Add(student);
            }
            string city = Console.ReadLine();
            List<Student> sorted = new List<Student>();

            for (int i = 0; i < students.Count; i++)
            {
                if (students.Contains())
                {

                }
            }
        }
    }
}
