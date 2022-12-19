class Program
{
    delegate int Operation(int x, int y);

    static void Main(string[] args)
    {
        Operation del = Add;
        del += Multiply;

        int result = del(6, 5);
        Console.WriteLine(result);
        Console.Read();
    }
    private static int Add(int x, int y) 
    {
        Console.WriteLine("Add");
        return x + y;
    }
    private static int Multiply(int x, int y) 
    {
        Console.WriteLine("Multiply");
        return x * y;
    }
}