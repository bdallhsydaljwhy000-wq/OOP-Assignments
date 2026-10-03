//OOP3
class Person
{
    public string Name;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"name is :{Name}");
    }
}

class Student : Person
{
    public int Id;

    public override void DisplayInfo()
    {
        Console.WriteLine($"studaent name:{Name}");
        Console.WriteLine($"student ID:{Id}");
    }
}

class Employee : Person
{
    public double Salary;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee name:{Name}");
        Console.WriteLine($"Employee Salary:{Salary}");
    }
}

class Teacher : Person
{
    public string CorseName;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher name:{Name}");
        Console.WriteLine($"Teacher Corse :{CorseName}");
    }
}

class Program
{
    static void DisplayPersonInfo(Person Person)
    {
        Person.DisplayInfo();
    }

    static void Main()
    {
        Student student = new Student();
        student.Name = "Saeed";
        student.Id = 77525;

        Employee employee = new Employee();
        employee.Name = "Ali";
        employee.Salary = 10;

        Teacher teacher = new Teacher();
        teacher.Name = "Saleh";
        teacher.CorseName = "Programing";

        List<Person> persons = new List<Person>();

        persons.Add( student );
        persons.Add( employee );
        persons.Add( teacher );

        foreach (Person person in persons)
        {
            Console.WriteLine(person.GetType().Name);

            person.DisplayInfo();
            Console.WriteLine();
        }
        DisplayPersonInfo(student);
    }
}


