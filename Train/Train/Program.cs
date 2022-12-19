class Message
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
}
class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}

interface IMessenger<in T, out K>
{
    void SendMessage(T message); // Контравариантность
    K WriteMessage(string text); //Ковариантность
}
class SimpleMessenger : IMessenger<Message, EmailMessage>
{
    public void SendMessage(Message message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
    public EmailMessage WriteMessage(string text)
    {
        return new EmailMessage($"Email: {text}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMessenger<EmailMessage, Message> messenger = new SimpleMessenger();
        EmailMessage message = messenger.WriteMessage("Hello World"); //Ковариантность
        Console.WriteLine(message.Text);
        messenger.SendMessage(new EmailMessage("Test"));

        IMessenger<EmailMessage, EmailMessage> outlook = new SimpleMessenger();
        EmailMessage emailMessage = outlook.WriteMessage("Message from Outlook");
        outlook.SendMessage(emailMessage);

        IMessenger<Message, Message> telegram = new SimpleMessenger();
        Message simpleMessage = telegram.WriteMessage("Message from Telegram");
        telegram.SendMessage(simpleMessage);

        Console.Read();
    }




}