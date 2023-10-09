using System.Collections.Generic;

namespace Rascunhos.Entities
{
    class Course
    {
        public string Name { get; set; }
        public HashSet<int> StudentsId { get; set; } = new HashSet<int>();

        public Course(string name, HashSet<int> studentsId)
        {
            Name = name;
            StudentsId = studentsId;
        }
    }
}
