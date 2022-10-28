using System.Runtime.CompilerServices;

namespace OOStepByStep;

public class Person
{
    public Person(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
    }

    public string name { get; set; }
    public int age { get; set; }
    public int title { get; set; }

    public string IntroduceSelf()
    {
        string msg = $"My name is {this.name}. I am {this.age.ToString()} years old.";
        return msg;
    }

}