enum Day
{
    Monday = 5,
    Tuesday,
    Wednesday,
    Thursday = 14,
    Friday = Tuesday,
    Saturday,
    Sunday
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine((int)Day.Sunday);
    }
}