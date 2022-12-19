class Person<T>
{
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

        Console.WriteLine(tomId);   // 546
        Console.WriteLine(bobId);   // abc123

        Company<Person<int>> microsoft = new Company<Person<int>>(tom);

        Console.WriteLine(microsoft.CEO.Id);  // 546
        Console.WriteLine(microsoft.CEO.Name);  // Tom
    }
}

