using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private readonly string className;
        private readonly Teacher teacher;
        private List<Student> students;

        public Class(string className)
        {
            this.className = className;
        }

        public void AddStudent(Student student)
        {
            //students.Add(student);
            student.JionClass(this.className);
        }
    }
}
