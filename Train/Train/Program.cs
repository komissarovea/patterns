class Person
{
    internal string Name { private get; set; } = "Bob";
}
class Program
{
    static void Main(string[] args)
    {
        //Person tom = new Person { Name = "Tom" };
        //Console.WriteLine(tom.Name);

        Console.ReadKey();
    }
}