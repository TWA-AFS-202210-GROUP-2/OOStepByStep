namespace OOStepByStepTest
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}