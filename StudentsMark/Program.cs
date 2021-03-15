using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsMark
{
    class Program
    {
        class StudentsMark
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<StudentsMark> students = new List<StudentsMark>();

            for (int i = 0; i < n; i++)
            {
                string studentsData = Console.ReadLine();
                string[] tokens = studentsData.Split();

                StudentsMark student = new StudentsMark
                {
                    FirstName = tokens[0],
                    LastName = tokens[1],
                    Grade = double.Parse(tokens[2])
                };

                students.Add(student);
            }

            List<StudentsMark> sorted = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in sorted)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}

