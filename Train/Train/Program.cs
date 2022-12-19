class Auto
{
    public string Name { get; set; }
}
class User
{
    public string Name { get; set; }
    public Auto Auto { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        User tom = new User { Name = "Tom", Auto = new Auto { Name = "Ford" } };
        int age = 34;
        var student = new { tom.Auto.Name, age };
        Console.WriteLine(student.Name);
        Console.Read();
    }
}