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
            Student person = new ("Tom", 21);
            string msgPerson = person.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", msgPerson);
        }

        [Fact]
        public void Should_Return_info_when_intruduce_given_a_teacher()
        {
            Teacher person = new Teacher("Amy", 30);
            string msgPerson = person.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", msgPerson);
        }

        [Fact]
        public void Should_Return_info_when_introduce_given_a_student_with_class()
        {
            SchoolClass schoolClass = new SchoolClass("1");
            Student student = new ("Tom", 21);
            student.AddToClass(schoolClass);

            string msgStudentWithClass = student.Introduce();

            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 1.", msgStudentWithClass);
        }

        [Fact]
        public void Should_Return_info_when_introduce_given_a_teacher_with_class()
        {
            SchoolClass schoolClass = new SchoolClass("1");
            Teacher teacher = new ("Amy", 30);
            teacher.AddToClass(schoolClass);

            string msgTeacherWithClass = teacher.Introduce();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 1.", msgTeacherWithClass);
        }
    }
}
