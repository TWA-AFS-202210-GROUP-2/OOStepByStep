namespace OOStepByStep;

public class Classroom
{
    public string className;

    public Classroom(string className)
    {
        this.className = className;
    }
    
    public void addTeacher(Teacher teacher)
    {
        teacher.setClass(this);
    }

    public void addStudent(Student student)
    {
        student.setClass(this);
    }
}