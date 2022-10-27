namespace OOStepByStep
{
    using OOStepByStepTest;
    using System;
    public class Teacher : Person
    {
        private string role = "teacher";
        private string className;
        public Teacher(string name, int age, string className = "") : base(name, age)
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
                return $"{baseIntroduction} I am a {role}.I am a teacher of class {className}.";
            }
        }
    }
}
