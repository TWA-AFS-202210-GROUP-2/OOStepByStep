namespace OOStepByStep
{
    using OOStepByStepTest;
    using System;
    public class Student : Person
    {
        private string role = "student";
        private string className;
        public Student(string name, int age, string className = "") : base(name, age)
        {
            this.className = className;
        }

        public override string Introduce()
        {
            var baseIntroduction = base.Introduce();
            if (className.Equals(string.Empty))
            {
                return $"{baseIntroduction} I am a {role}.";
            }
            else
            {
                return $"{baseIntroduction} I am a {role}.I am a student of class {className}.";
            }
        }
    }
}
