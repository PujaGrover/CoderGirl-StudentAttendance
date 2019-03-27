using System;
using System.Collections.Generic;

namespace StudentAttendance
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student studentNameAndScores = new Student();
            students = studentNameAndScores.GetStudentScoresFromFileStudentData();
            foreach (var student in students)
            {
                if (student.HasSixOrMore())
                {
                    Console.WriteLine($"{student.Name}");
                }               
            }
            Console.ReadLine();
        }
    }
}