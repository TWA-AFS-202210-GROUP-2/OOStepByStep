using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string className;
        public Student(string name, int age) : base(name, age)
        {
        }

        public void JionClass(string className)
        {
            this.className = className;
        }

        public override string Introduction()
        {
            return base.Introduction() + $" I am a student of {this.className}.";
        }
    }
}
