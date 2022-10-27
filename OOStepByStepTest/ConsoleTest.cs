using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOPractice;
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Should_return_message_when_speed_and_carname()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            string message = person.Introduce();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", message);
        }
    }
}
