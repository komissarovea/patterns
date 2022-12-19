int j = 2;
for (int i = 2; i < 32; i = i * 2)
{
    while (i < j)
    {
        j = checked((int)(j * 2));
        Console.WriteLine(j);
    }
    i = j - i;
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
