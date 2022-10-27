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
            Student student = new Student(name, age);
            // when
            string ans = "My name is Tom. I am 18 years old. I am a student.";
            string msg = student.IntroduceSelf();

            // then

            Assert.Equal(ans, msg);
        }
        [Fact]
        public void Should_return_msg_when_introduce_given_info_plus_teacher()
        {
            //given
            string name = "Amy";
            int age = 30;
            string titleName = "student";
            Teacher teacher = new Teacher(name, age);
            // when
            string ans = "My name is Amy. I am 30 years old. I am a teacher.";
            string msg = teacher.IntroduceSelf();

            // then

            Assert.Equal(ans, msg);
        }
        [Fact]
        public void Should_return_msg_when_introduce_given_class_info_plus_teacher()
        {
            //given
            string name = "Amy";
            int age = 30;
            string className = "class 2";
            Classroom class2 = new Classroom(className);
            Teacher teacher = new Teacher(name, age);
            class2.addTeacher(teacher);
            // when
            string ans = "My name is Amy. I am 30 years old. I am a teacher of class 2.";
            string msg = teacher.IntroduceSelf();

            // then

            Assert.Equal(ans, msg);
        }
        [Fact]
        public void Should_return_msg_when_introduce_given_class_info_plus_student()
        {
            //given
            string name = "Tom";
            int age = 18;
            string className = "class 2";
            Classroom class2 = new Classroom(className);
            Student student = new Student(name, age);
            class2.addStudent(student);
            // when
            string ans = "My name is Tom. I am 18 years old. I am a student of class 2.";
            string msg = student.IntroduceSelf();

            // then

            Assert.Equal(ans, msg);
        }
        [Fact]
        public void Should_return_greet_msg_when_given_class_new_student()
        {
            //given
            Teacher teacher = new Teacher("Amy",30);
            string name = "Tom";
            int age = 18;
            string className = "class 2";
            Classroom class2 = new Classroom(className);
            Student student = new Student(name, age);
            class2.addTeacher(teacher);

            // when
            string msg = class2.addStudent(student);
            string ans = "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.";
            // then
            Assert.Equal(ans, msg);
        }


        [Fact]
            public void Should_stus_return_greet_msg_when_given_class_new_student()
        {
            //given
           
            string name = "Tom";
            int age = 18;
            string className = "class 2";
            Classroom class2 = new Classroom(className);
            Student student = new Student(name, age);
            Student newstudent = new Student("Jim", 100);

            string msg_1 = class2.addStudent(student);
            string msg_2 = class2.addStudent(newstudent);
            // when
            string ans = "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.";
            // then
            Assert.Equal(ans, msg_2);
        }
    }
}