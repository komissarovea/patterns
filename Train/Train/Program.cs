﻿class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        Console.Write(i++ * Calculate(i));
        Console.WriteLine(i);

        Console.ReadKey();
    }

    public static int Calculate(int i)
    {
        Console.Write(i++);
        return i;
    }
}