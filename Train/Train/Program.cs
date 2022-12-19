using System.Text;

char c = 'a';
int a = 1;

unsafe
{
    Console.WriteLine(Encoding.Unicode.GetByteCount("aaы"));
}

int[] array = new int[33];
int[,] nums = new int[3,3];

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
