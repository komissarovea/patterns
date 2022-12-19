class Program
{
    delegate void Message();

    static void Main(string[] args)
    {
        Message mes1 = Hello;
        mes1 += HowAreYou;
        mes1 += Hello;
        mes1 += Hello;
        mes1 -= Hello;
        mes1();

        Console.Read();
    }
    private static void Hello() { Console.WriteLine("Hello"); }
    private static void HowAreYou() { Console.WriteLine("How are you?"); }
}