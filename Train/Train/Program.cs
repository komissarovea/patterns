
class Person
{
    public string Name { get; set; }
    public virtual void Display()
    {
        Console.WriteLine($"Person {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }
    public sealed override void Display()
    {
        Console.WriteLine($"Employee {Name}");
    }
}


sealed class Manager : Employee
{
    public new void Display()
    {
        Console.WriteLine($"Manager {Name}");
    }

 
}
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[33];

        Person person = new Manager { Name = "Bob", Company = "Microsoft" };
        person.Display();
        Employee employee = person as Employee;
        employee.Display();

        Manager manager = person as Manager;
        manager.Display();

        Console.ReadKey();
    }
}