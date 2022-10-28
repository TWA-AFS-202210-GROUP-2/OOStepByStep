using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, string classNumber) : base(name, age, classNumber)
        {
        }

        public override string IntroduceOneself()
        {
            if (this.ClassNumber == string.Empty)
            { return $"My name is {Name}. I am {Age} years old. I am a student."; }
            else
            { return $"My name is {Name}. I am {Age} years old. I am a student of {ClassNumber}."; }
}
    }
}
