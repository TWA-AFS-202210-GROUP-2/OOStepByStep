using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            ClassNumber = string.Empty;
        }

        public Person(string name, int age, string classNumber)
        {
            Name = name;
            Age = age;
            ClassNumber = classNumber;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string ClassNumber { get; set; }
        public virtual string IntroduceOneself()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}
