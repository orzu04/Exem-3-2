namespace task6;

class Dog : Animal
{

    public  Dog (string name):base(name)
    {

    }
    public override void Greets()
    {
      System.Console.WriteLine($"Woof");
    }

    public virtual void Greetse ()
    {

       System.Console.WriteLine($"Wooof");
    }
}
