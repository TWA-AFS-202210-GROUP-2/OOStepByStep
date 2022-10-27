namespace OOStepByStep
{
    using OOStepByStepTest;
    using System;
    public class Student : Person
    {
        private string role = "student";
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            var baseIntroduction = base.Introduce();
            return $"{baseIntroduction} I am a {role}.";
        }
    }
}
