namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Xml.Serialization;
    using Xunit;

    public class ClassTest
    {
        [Fact]
        public void Should_return_introduction_when_run_introduce_given_person_name_and_age()
        {
            Person person = new Person("Tom", 21);
            var introduction = person.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }
    }
}
