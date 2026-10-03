//OOP2
class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Name=name;
        Email=email;

        Console.WriteLine("Person constructor");
    }
    public void DisplayBasicinfo()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Email:{Email}");
    }
}

class Student: Person
{
    public int studentId;
    public double studentGPA;

    public Student(string name , string email,int studentid, double studentgpa) : base(name,email)
    {
        studentId = studentid;
        studentGPA = studentgpa;
        Console.WriteLine("Studant constructor");
    }
}
 class Employee : Person
{
    public int employeeId;
    public double Salary;

    public Employee( string name, string email ,int employeeid, double salary) : base(name,email) 
    {
        employeeId = employeeid;
        Salary = salary;
        Console.WriteLine("Employee constructor");
    }
}
class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, int employeeid, double salary, string courseName) : base(name, email, employeeid, salary)
    {
        CourseName = courseName;
        Console.WriteLine("Teacher constructor");
    }
    public void Teach()
    {
        Console.WriteLine($"Teacher is teaching:{CourseName}");
    }
}

class Program
{
    static void Main()
    {
        Student student=new Student("ali","Ali@gamil.com",77,5000);
        Console.WriteLine();
        Teacher teacher = new Teacher("Ahmed","ahmed@gamil",55,7000,"Programing");
        student.DisplayBasicinfo();
        Console.WriteLine();
        teacher.DisplayBasicinfo();
        teacher.Teach();

    }
}
