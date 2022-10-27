using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class SchoolClass
    {
        public SchoolClass(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teacher = teacher;
        }
    }
}
