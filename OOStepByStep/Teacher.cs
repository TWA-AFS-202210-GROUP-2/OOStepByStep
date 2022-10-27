using System.Dynamic;

namespace OOStepByStep;

public class Teacher : Person
{
    Classroom myClassroom = null;
    public Teacher(string name, int age) : base(name, age)
    {
    }

    public string IntroduceSelf()
    {
        string msg = $"My name is {this.name}. I am {this.age.ToString()} years old. I am a teacher.";
        if (myClassroom != null)
        {
            msg = $"My name is {this.name}. I am {this.age.ToString()} years old. I am a teacher of {myClassroom.className}.";
        }
        return msg;
    }

    public void setClass(Classroom @class)
    {
        myClassroom = @class;
    }
}