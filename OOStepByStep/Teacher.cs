using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public string SchoolClassName { get; set; } = string.Empty;
        public new string Introduce()
        {
            string introduceMessage = (SchoolClassName != string.Empty) ?
                $"{base.Introduce()} I am a teacher of class {SchoolClassName}."
                : $"{base.Introduce()} I am a teacher.";
            return introduceMessage;
        }

        public void AddToClass(SchoolClass schoolClass)
        {
            this.SchoolClassName = schoolClass.Name;
        }
    }
}
