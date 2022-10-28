namespace OOPractice
{
    public class Person
    {
        public Person(string name, int age, string type, int classnumber)
        {
            Name = name;
            Age = age;
            Type = type;
            ClassNumber = classnumber;
        }

        public string Name { get; }
        public int Age { get; }
        public string Type { get; }
        public int ClassNumber { get; }
        public string Introduce()
        {
            if (Type == "student")
            {
                return "My name is " + Name + ". I am " + Age.ToString() + " years old. I am a student of class " + ClassNumber.ToString() + ".";
            }

            return "My name is " + Name + ". I am " + Age.ToString() + " years old. I am a teacher of class " + ClassNumber.ToString() + ".";
        }
    }
}