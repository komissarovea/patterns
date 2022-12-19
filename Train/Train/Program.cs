class Program
{
    delegate void Message();

    static void Main(string[] args)
    {
        Message mes = new Message(Hello);
        mes += Hi;
        mes -= Hello;
        mes -= Hi;
        mes();
        Console.Read();
    }
    private static void Hello() { Console.WriteLine("Hello"); }
    private static void Hi() { Console.WriteLine("Hi"); }
}