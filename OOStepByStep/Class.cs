namespace OOStepByStep
{
    using OOStepByStepTest;
    using System;
    using System.Collections.Generic;

    public class Class
    {
        private string className;
        private List<Student> students;
        private Teacher teacher;
        public Class(string className, Teacher teacher, List<Student> students)
        {
            //how to limit the students className
            this.className = className;
            this.teacher = teacher;
            this.students = students;
        }

        public string TeacherWelcomeNewStudent(Student newStudent)
        {
            return teacher.IntroduceForWelcome(newStudent);
        }

        public string StudentsWelcomeNewStudent(Student newStudent)
        {
            var message = string.Empty;
            foreach (Student student in students)
            {
                message += student.IntroduceForWelcome(newStudent);
            }

            return message;
        }
    }
}