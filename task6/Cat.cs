﻿using System.Security.Cryptography.X509Certificates;

namespace task6;

 class Cat:Animal
{

  public Cat(string name):base(name)
  {
  }

    public override void Greets()
    {
        System.Console.WriteLine($"Meow");
    }
}
