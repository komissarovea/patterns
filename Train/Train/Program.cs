public class RunAction : IRunAction
{
    public void Move()
    {
        Console.WriteLine("I am running");
    }

}

public interface IAction
{
    void Move();
}
internal interface IRunAction : IAction
{
     new void Move();
}

class Program
{
    static void Main(string[] args)
    {

        IAction action = new RunAction();
        action.Move();

        Console.ReadKey();
    }


}

