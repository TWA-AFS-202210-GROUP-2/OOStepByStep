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

        public Teacher(string name, int age, string classNumber) : base(name, age, classNumber)
        {
        }

        public override string IntroduceOneself()
        {
            if (this.ClassNumber == string.Empty)
            { return $"My name is {Name}. I am {Age} years old. I am a teacher."; }
            else
            { return $"My name is {Name}. I am {Age} years old. I am a teacher of {ClassNumber}."; }
        }
    }
}
