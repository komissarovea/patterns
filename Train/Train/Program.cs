class Person<T> 
{
    public T Id { get; }
    public Person(T id)
    {
        Id = id;
    }
}

class UniversalPerson<T> : Person<T>
{
    public UniversalPerson(T id) : base(id) { }
}


class StringPerson : Person<string>
{
    public StringPerson(string id) : base(id) { }
}

class IntPerson<T> : Person<int>
{
    public T Code { get; set; }
    public IntPerson(int id, T code) : base(id)
    {
        Code = code;
    }
}

class MixedPerson<T, K> : Person<T>
    where K : struct
{
    public K Code { get; set; }
    public MixedPerson(T id, K code) : base(id)
    {
        Code = code;
    }
}

class Program
{
    static void Main(string[] args)
    {
        StringPerson person4 = new StringPerson("438767");
        Person<string> person5 = new StringPerson("43875");
        // так нельзя написать
        //Person<int> person6 = new StringPerson("45545");
        Console.WriteLine(person4.Id);
        Console.WriteLine(person5.Id);

        IntPerson<string> person7 = new IntPerson<string>(5, "r4556");
        Person<int> person8 = new IntPerson<long>(7, 4587);
        Console.WriteLine(person7.Id);
        Console.WriteLine(person8.Id);

        MixedPerson<string, int> person9 = new MixedPerson<string, int>("456", 356);
        Person<string> person10 = new MixedPerson<string, int>("9867", 35678);
        Console.WriteLine(person9.Id);
        Console.WriteLine(person10.Id);
    }


}

