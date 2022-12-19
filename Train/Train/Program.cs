class Person<T>
{
    public static T? code;

    public T Id { get; set; }
    public string Name { get; set; }
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Company<P>
{
    public P CEO { get; set; }  // президент компании
    public Company(P ceo)
    {
        CEO = ceo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person<int> tom = new Person<int>(546, "Tom");  // упаковка не нужна
        Person<string> bob = new Person<string>("abc123", "Bob");

        int tomId = tom.Id;      // распаковка не нужна
        string bobId = bob.Id;  // преобразование типов не нужно
        Company<Person<int>> microsoft = new Company<Person<int>>(tom);


        Person<int>.code = 1234;
        Person<string>.code = "meta";

        Console.WriteLine(Person<int>.code);       // 1234
        Console.WriteLine(Person<string>.code);   // meta
    }
}

