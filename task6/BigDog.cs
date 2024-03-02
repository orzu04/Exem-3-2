using System.Diagnostics;

namespace task6;

 class BigDog:Dog
{
    public BigDog(string name) : base(name)
    {
    }

    public override void Greets()
    {
        base.Greets();
    }
    public override void Greetse()
    {
        base.Greetse();
    }
    public void GreetBD()
    {
        System.Console.WriteLine($"Wooooooooooof");
    }
 
}
