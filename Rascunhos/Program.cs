using System;
using System.Collections.Generic;
using System.IO;
using Rascunhos.Entities;

namespace Rascunhos
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherEntities teacherEntities = new TeacherEntities();
            Console.Write("Teacher name: ");
            string name = Console.ReadLine();
            teacherEntities.TeacherName = name;

            Console.Write("How many courses? ");
            int quantity = int.Parse(Console.ReadLine());
            teacherEntities.AddMultCourse(quantity);
            
            int totalStudents = teacherEntities.TotalStudants();
            Console.Write("Alex total students: " + totalStudents);
        }
    }
}
