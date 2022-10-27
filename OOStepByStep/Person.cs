namespace OOPractice
{
    public class Person
    {
        public Person(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public string Name { get; }
        public int Age { get; }
        public string Type { get; }

        public string Introduce()
        {
            if (Type == "student")
            {
                return "My name is " + Name + ". I am " + Age.ToString() + " years old. I am a student.";
            }

            return "My name is " + Name + ". I am " + Age.ToString() + " years old. I am a teacher.";
        }
    }
}