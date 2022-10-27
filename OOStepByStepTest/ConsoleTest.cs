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

        [Fact]
        public void Should_return_introduction_when_student_given_name_age()
        {
            // given
            var student = new Student("Tom", 18);

            // when
            var introductionString = student.Introduction();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introductionString);
        }

        [Fact]
        public void Should_return_introduction_when_teacher_given_name_age()
        {
            // given
            var teacher = new Teacher("Amy", 30);

            // when
            var introductionString = teacher.Introduction();

            // then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introductionString);
        }

        [Fact]
        public void Should_return_introduction_when_student_given_class()
        {
            // given
            var student = new Student("Tom", 18);
            var className = new Class("class 2");

            // when
            className.AddStudent(student);
            var introductionString = student.Introduction();

            // then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", introductionString);
        }
    }
}
