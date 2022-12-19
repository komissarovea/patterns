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

interface IFoo
{
    void Execute();
}
interface IBar
{
    void Execute();
}
class Tester : IFoo, IBar
{
    public void Execute()
    {
        Console.WriteLine("Tester Executes");
    }

    void IFoo.Execute()
    {
        Console.WriteLine("IFoo Executes");
    }
    void IBar.Execute()
    {
        Console.WriteLine("IBar Executes");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tester t = new Tester();
        t.Execute();

        ((IBar)t).Execute();
        (t as IFoo).Execute();

        IAction action = new RunAction();
        action.Move();

        Console.ReadKey();
    }
}

