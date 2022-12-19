class Instantiator<T> where T :  new()
{
    public T instance;
    public Instantiator()
    {
        instance = new T();
    }
}

class Messenger<T> where T : Message, new()
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}

class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}

class Messenger<T, P>
    where T : Message
    where P : Person
{
    public void SendMessage(P sender, P receiver, T message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}
class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class Program
{
    static void Main(string[] args)
    {
        string s1 = "test";
        string s2 = "test";
        string s3 = "test1".Substring(0, 4);
        object s4 = s3;

        Console.WriteLine($"{object.ReferenceEquals(s1, s2)} {s1 == s2} {s1.Equals(s2)}");
        Console.WriteLine($"{object.ReferenceEquals(s1, s3)} {s1 == s3} {s1.Equals(s3)}");
        Console.WriteLine($"{object.ReferenceEquals(s1, s4)} {s1 == s4} {s1.Equals(s4)}");
    }


}

