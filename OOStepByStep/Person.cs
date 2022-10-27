namespace OOPractice
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public string Introduce()
        {
            return "My name is " + Name + ". I am " + Age.ToString() + " years old.";
        }
    }
}