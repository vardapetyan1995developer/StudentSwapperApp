using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSwapper.Models;
using StudentSwapper.Managers;

namespace StudentSwapper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentModel> students = Manager.GenerateStudents(10);
            List<TeacherModel> teachers = Manager.GenerateTeachers();
            List<GradeModel> grades = Manager.GenerateGrades();
            List<TeacherModel> swappedTeachers = Manager.SwapStudentsAndGrades(students, teachers, grades);

            Manager.ShowResult(swappedTeachers);




            Console.ReadKey();
        }
    }
}
