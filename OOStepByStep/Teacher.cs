namespace OOStepByStep
{
    using OOStepByStepTest;
    using System;
    public class Teacher : Person
    {
        private string role = "teacher";
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            var baseIntroduction = base.Introduce();
            return $"{baseIntroduction} I am a {role}.";
        }
    }
}
