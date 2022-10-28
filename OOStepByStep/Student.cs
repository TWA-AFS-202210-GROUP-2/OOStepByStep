using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public string SchoolClassName { get; set; } = string.Empty;
        public void AddToClass(SchoolClass schoolClass)
        {
            schoolClass.AddStudent(this);
            SchoolClassName = schoolClass.Name;
        }

        public new string Introduce()
        {
            string introduceMessage = (SchoolClassName != string.Empty) ?
                $"{base.Introduce()} I am a student of class {SchoolClassName}."
                : $"{base.Introduce()} I am a student.";
            return introduceMessage;
        }
    }
}
