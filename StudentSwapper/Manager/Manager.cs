using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSwapper.Models;
using StudentSwapper.Managers;

namespace StudentSwapper.Managers
{
    public static class Manager
    {
        public static List<StudentModel> GenerateStudents(int count)
        {
            if (count < 4)
                throw new Exception("Number of students must be more than 9");

            Random random = new Random();

            List<StudentModel> students = new List<StudentModel>(count);

            for(int i = 0; i < count; i++)
            {
                students.Add(new StudentModel {
                    FirstName = $"Tigran{i}",
                    LastName = $"Margaryan{i}",
                    Age = random.Next(18, 50),
                    Id = i + 1,
                    Fee = 1000
                });
            }
            return students;
        }

        public static List<TeacherModel> GenerateTeachers()
        {
            Random random = new Random();

            List<TeacherModel> teachers = new List<TeacherModel>(4);

            for(int i = 0; i < 4; i++)
            {
                teachers.Add(new TeacherModel {
                    FirstName = "Aram",
                    LastName = "Meliqyan",
                    Age = random.Next(28, 70),
                    Id = i + 1
                });
            }
            return teachers;
        }

        public static List<GradeModel> GenerateGrades()
        {
            Random random = new Random();

            List<GradeModel> grades = new List<GradeModel>();

            for(int i = 0; i < 5; i++)
            {
                grades.Add(new GradeModel {
                    GradeNumber = (byte)random.Next(1, 5),
                    GradeName = $"Grade {i}",
                    Id = i
                });
            }

            return grades;
        }

        public static List<TeacherModel> SwapStudentsAndGrades(List<StudentModel> students, List<TeacherModel> teachers, List<GradeModel> grades)
        {
            int range = students.Count / 4;

            teachers[0].Students = students.GetRange(0, range);
            teachers[0].Grade = grades[0];
            teachers[1].Students = students.GetRange(range, range);
            teachers[1].Grade = grades[1];
            teachers[2].Students = students.GetRange(2 * range, range);
            teachers[2].Grade = grades[2];
            teachers[3].Students = students.GetRange(3 * range, students.Count - 3 * range);
            teachers[3].Grade = grades[3];

            return teachers;
        }

        public static void ShowResult(List<TeacherModel> teachers)
        {
            foreach (TeacherModel item in teachers)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("***************************************");
                Console.WriteLine($"Teacher ID: {item.Id}");
                Console.WriteLine($"Teacher FullName: {item.FullName}");
                Console.WriteLine($"Teacher Age: {item.Age}");

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("*****Teachers Studetns*****");

                foreach (var student in item.Students)
                { 
                    Console.WriteLine("*******************");

                    Console.WriteLine($"Student ID: {student.Id}");
                    Console.WriteLine($"Student FullName: {student.FullName}");
                    Console.WriteLine($"Student Age: {student.Age}");
                    Console.WriteLine($"Student Fee: {student.Fee}");
                    Console.WriteLine($"Student GradeId: {item.Grade.Id}");
                    //Console.WriteLine($"Student GradeId: {item.Grade}");
                    Console.WriteLine($"Student GradeName: {item.Grade.GradeName}");
                }
            }
        }
    }
}
