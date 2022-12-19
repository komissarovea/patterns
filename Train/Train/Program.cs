class Counter
{
    public int Number { get; set; }

    public static int operator +(int val, Counter counter)
    {
        return counter.Number + val;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter { Number = 45 };
        int x = 6 + counter;
        Console.WriteLine(x);  // 51

        Console.ReadKey();
    }
}