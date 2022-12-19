class Message
{
    public string Text { get; }
    public Message(string text) => Text = text;
    public virtual void Print() => Console.WriteLine($"Message: {Text}");
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Email: {Text}");
}
class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
    public override void Print() => Console.WriteLine($"Sms: {Text}");
}

class Program
{

    delegate Message MessageBuilder(string text);
    delegate void EmailReceiver(EmailMessage message);

    static void Main(string[] args)
    {
        // делегату с базовым типом передаем метод с производным типом
        MessageBuilder messageBuilder = WriteEmailMessage; // ковариантность
        Message message = messageBuilder("Hello");
        message.Print();    // Email: Hello


        EmailReceiver emailBox = ReceiveMessage; // контравариантность
        emailBox(new EmailMessage("Welcome"));  // Email: Welcome


        Console.Read();
    }

    static EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);

    static void ReceiveMessage(Message message) => message.Print();


}