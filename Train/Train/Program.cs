class Account
{
    public delegate void AccountHandler(string message);
    public event AccountHandler? Notify;              // 1.Определение события
    public Account(int sum) => Sum = sum;
    public int Sum { get; private set; }
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
        }
        else
        {
            Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
        }
    }
}

class Program
{

    static void Main(string[] args)
    {
        Account account = new Account(100);
        account.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
        account.Put(20);    // добавляем на счет 20
        Console.WriteLine($"Сумма на счете: {account.Sum}");
        account.Take(70);   // пытаемся снять со счета 70
        Console.WriteLine($"Сумма на счете: {account.Sum}");
        account.Take(180);  // пытаемся снять со счета 180
        Console.WriteLine($"Сумма на счете: {account.Sum}");

        // установка делегата, который указывает на метод DisplayMessage
        account.Notify += new Account.AccountHandler(DisplayMessage);

        account.Notify += delegate (string mes)
        {
            Console.WriteLine(mes);
        };

        account.Notify += message => Console.WriteLine(message);

        void DisplayMessage(string message) => Console.WriteLine(message);

        Console.Read();
    }
}