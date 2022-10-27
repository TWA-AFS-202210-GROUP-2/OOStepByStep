using OOStepByStep;
namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }

        [Fact]
        public void Should_Return_info_when_intruduce_given_a_person()
        {
            Person person = new Person("Tom", 21);
            string msgPerson = person.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old.", msgPerson);
        }

        [Fact]
        public void Should_Return_info_when_intruduce_given_a_student()
        {
            Student person = new Student("Tom", 21);
            string msgPerson = person.Introduce();
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", msgPerson);
        }
    }
}
