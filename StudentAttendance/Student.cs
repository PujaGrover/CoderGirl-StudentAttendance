using System;
using System.Collections.Generic;
using System.IO;

namespace StudentAttendance
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public bool HasSixOrMore()
        {
            //The code below works too but is a longer way of doing it
            //List<Student> students = new List<Student>();
            //Student studentNameAndScores = new Student();
            //students = studentNameAndScores.GetStudentScoresFromFileStudentData();
            //foreach (var student in students)
            //{
            //    // return Scores.Length >= 6 ? true : false;
            //}
            return Scores.Length >= 6 ? true : false;
        }

        // add data from file into the list line by line
        public List<Student> GetStudentScoresFromFileStudentData()
        {
            //Declaring a List that will contain each student detail stored line by line
            List<Student> students = new List<Student>();
            foreach (string line in File.ReadLines(@"studentdata.txt"))
            {
                Student student = CreateStudentRecord(line);
                students.Add(student);

            }
            return students;
        }

        public Student CreateStudentRecord(string line)
        {
            Student student = new Student();

            string[] eachStudentDetail = line.Split(" ");

            string[] tempScore = new string[eachStudentDetail.Length - 1];
            for (int i = 0; i < eachStudentDetail.Length; i++)
            {
                if (i == 0)
                    student.Name = eachStudentDetail[0];
                else
                {
                    tempScore[i - 1] = eachStudentDetail[i];
                }

            }
            student.Scores = Array.ConvertAll(tempScore, int.Parse);

            return student;
        }

    }
}