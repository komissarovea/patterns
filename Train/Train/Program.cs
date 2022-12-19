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
        Message message = messenger.WriteMessage("Hello World");
        Console.WriteLine(message.Text);
        messenger.SendMessage(new EmailMessage("Test")); // Контравариантность

        IMessenger<EmailMessage, EmailMessage> outlook = new SimpleMessenger();
        EmailMessage emailMessage = outlook.WriteMessage("Message from Outlook");
        outlook.SendMessage(emailMessage); // Контравариантность

        IMessenger<Message, Message> telegram = new SimpleMessenger();
        Message simpleMessage = telegram.WriteMessage("Message from Telegram");
        telegram.SendMessage(simpleMessage); // Контравариантность

        // * out -возвращает наружу, ковариантность - больше вариантов, более частное
        //* in -принимает внутрь, контрвариантность - меньше вариантов, более общее

        Console.Read();
    }


}