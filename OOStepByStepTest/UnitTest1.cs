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
        public void Should_return_personal_introduction_when_given_personal_info()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            var result = person.IntroduceOneself();
            //then
            Assert.Equal("My name is Tom. I am 21 years old.", result);
        }
    }
}
