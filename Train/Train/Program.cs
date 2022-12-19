class Message
{
    public string Text { get; } // текст сообщения
    public Message(string text)
    {
        Text = text;
    }

    public object Clone() => MemberwiseClone();
}

class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}
class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
}

class Messenger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}

class Instantiator<T> 
{
    public T instance;
    public Instantiator()
    {
        instance = default(T);
    }
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

    void SendMessage<T>(T message) where T : Message
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }

}

