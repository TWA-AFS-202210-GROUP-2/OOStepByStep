using System.Collections.Generic;
using System.Linq;

namespace OOStepByStep;

public class Classroom
{
    public string className;
    public Teacher _teacher = null;
    public List<Student> _students = new List<Student>();


    public Classroom(string className)
    {
        this.className = className;
    }
    
    public void addTeacher(Teacher teacher)
    {
        teacher.setClass(this);
        this._teacher = teacher;
    }

    public string addStudent(Student student)
    {
        student.setClass(this);
       
        if (_teacher != null)
        {
            return _teacher.greetNewStudent(student);
        }
        if (_students.Count!= 0)
        {
            Msg = _students.Select((classstudent => classstudent.greetNewStudent(student)));
            return string.Join("\n", Msg);
        }
        
        _students.Add(student);
        return null;
    }

    public IEnumerable<string> Msg { get; set; }
}