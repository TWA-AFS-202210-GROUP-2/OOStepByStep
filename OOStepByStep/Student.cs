using System;

namespace OOStepByStep;

public class Student : Person
{
    public Student(string name, int age) : base(name, age)
    {
    }

    public string IntroduceSelf()
    {
        string msg = $"My name is {this.name}. I am {this.age.ToString()} years old. I am a student.";
        if (myClassroom != null)
        {
            msg = $"My name is {this.name}. I am {this.age.ToString()} years old. I am a student of {myClassroom.className}.";
        }
        return msg;
    }

    public void setClass(Classroom @class)
    {
        myClassroom = @class;
    }

    public string greetNewStudent(Student student)
    {
        return IntroduceSelf() + $" Welcome {student.name} join {myClassroom.className}.";
    }

    public Classroom myClassroom { get; set; }
}