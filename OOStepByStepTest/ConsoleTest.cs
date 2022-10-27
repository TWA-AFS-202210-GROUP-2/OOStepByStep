using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void Should_return_introduction_when_person_given_name_age()
        {
            // given
            var person = new Person("Tom", 18);

            // when
            var introductionString = person.Introduction();

            // then
            Assert.Equal("My name is Tom. I am 18 years old.", introductionString);
        }
    }
}
