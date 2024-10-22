using System;

// Enum for Department
public enum Department
{
    ComputerScience,
    ElectricalEngineering,
    MechanicalEngineering,
    CivilEngineering
}

// Base class Person
public class Person
{
    // Instance variable
    public string Name { get; set; }

    // No-argument constructor
    public Person()
    {
        Name = null;  // Default value for string is null
    }

    // Multi-argument constructor
    public Person(string name)
    {
        Name = name;
    }
}

// Derived class Student
public class Student : Person
{
    // Instance variables
    public string RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

    // No-argument constructor
    public Student() : base()
    {
        RegNo = null;  // Default value for string is null
        Age = 0;       // Default value for int is 0
        Program = Department.ComputerScience;  // Default enum value
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
}

// Test the classes
class Program
{
    static void Main(string[] args)
    {
        // Using no-argument constructor
        Student student1 = new Student();
        Console.WriteLine($"Student1 - Name: {student1.Name}, RegNo: {student1.RegNo}, Age: {student1.Age}, Program: {student1.Program}");

        // Using multi-argument constructor
        Student student2 = new Student("Tooba", "233518", 18, Department.ComputerScience);
        Console.WriteLine($"Student2 - Name: {student2.Name}, RegNo: {student2.RegNo}, Age: {student2.Age}, Program: {student2.Program}");
    }
}
