using System.Runtime.CompilerServices;
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
            Person person = new Person(name,age);
            // when
            string ans = "My name is Tom. I am 21 years old.";
            string msg = person.IntroduceSelf();

            // then

            Assert.Equal(ans, msg);
        }
    }

    public class Person
    {
        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }

        public string name { get; set; }
        public int age { get; set; }

        public string IntroduceSelf()
        {
            string msg = $"My name is {this.name}. I am {this.age.ToString()} years old.";
            return msg;
        }
    }
}