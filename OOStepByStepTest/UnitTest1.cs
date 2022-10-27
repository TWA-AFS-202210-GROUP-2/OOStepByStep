using System.Runtime.CompilerServices;
using System.Security.Principal;
using Microsoft.VisualBasic;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_msg_when_introduce_given_info()
        {
            //given
            string name = "Tom";
            int age = 21;
            Person person = new Person(name, age);
            // when
            string ans = "My name is Tom. I am 21 years old.";
            string msg = person.IntroduceSelf();

            // then
            Assert.Equal(ans, msg);
        }

        [Fact]
        public void Should_return_msg_when_introduce_given_info_plus_title()
        {
            //given
            string name = "Tom";
            int age = 18;
            string titleName = "student";
            Student student = new Student(name, age, titleName);
            // when
            string ans = "My name is Tom. I am 18 years old. I am a student.";
            string msg = student.IntroduceSelf();

            // then

            Assert.Equal(ans, msg);
        }
    }

    public class Student : Person
    {
        public Student(string name, int age, string titleName) : base(name, age)
        {
        }

        public string IntroduceSelf()
        {
            string msg = $"My name is {this.name}. I am {this.age.ToString()} years old. I am a student.";
            return msg;
        }

    }
}