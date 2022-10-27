namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Security.Cryptography;
    using System.Xml.Linq;
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

        [Fact]
        public void Should_return_introduction_when_run_introduce_given_student_name_and_age()
        {
            Student student = new Student("Tom", 18);
            var introduction = student.Introduce();
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduction);
        }

        [Fact]
        public void Should_return_introduction_when_run_introduce_given_teacher_name_and_age()
        {
            Teacher teacher = new Teacher("Amy", 30);
            var introduction = teacher.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduction);
        }
    }
}
