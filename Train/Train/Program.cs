class Person<T, K>
{
    public T Id { get; }
    public K Password { get; set; }
    public string Name { get; }
    public Person(T id, K password, string name)
    {
        Id = id;
        Name = name;
        Password = password;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person<int, string> tom = new Person<int, string>(546, "qwerty", "Tom");
        Console.WriteLine(tom.Id);  // 546
        Console.WriteLine(tom.Password);// qwerty

        int x = 7;
        int y = 25;
        Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
        Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

        string s1 = "hello";
        string s2 = "bye";
        Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
        Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello
    }

    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}

