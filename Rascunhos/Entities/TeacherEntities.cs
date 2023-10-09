using System;
using System.Collections.Generic;

namespace Rascunhos.Entities
{
    class TeacherEntities
    {
        public string TeacherName { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();               

        public int TotalStudants()
        {
            HashSet<int> aux = new HashSet<int>(Courses[0].StudentsId);

            for (int i = 1; i < Courses.Count; i++)
            {
                aux.UnionWith(Courses[i].StudentsId);
            }
            return aux.Count;
        }

        public void AddMultCourse(int courseQuantity)
        {
            for(int i = 0; i < courseQuantity; i++)
            {
                AddCourse();
            }           
        }

        public void AddCourse()
        {
            Console.Write("Enter de course name: ");
            string courserName = Console.ReadLine();
            HashSet<int> ids = new HashSet<int>();

            Console.Write($"How namy students for course {courserName}? ");
            int quantity = int.Parse(Console.ReadLine());
            for (int j = 0; j < quantity; j++)
            {
                int id = int.Parse(Console.ReadLine());
                ids.Add(id);
            }
            Course course = new Course(courserName, ids);

            Courses.Add(course);
            Console.WriteLine();
        }
    }
}
