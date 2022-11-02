using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string className;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public void JionClass(string className)
        {
            this.className = className;
        }

        public override string Introduction()
        {
            if (this.className == null)
            {
                return base.Introduction() + $" I am a teacher.";
            }

            return base.Introduction() + $" I am a teacher of {this.className}.";
        }
    }
}
