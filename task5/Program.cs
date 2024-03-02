



using task5;

var pers = new Person("Orzu","N.Rudaki");


System.Console.WriteLine(pers.GetName());
System.Console.WriteLine(pers.GetAddress());

System.Console.WriteLine(pers.ToString());

System.Console.WriteLine($"______________________");

var std = new Student("C#",21,3000,"Ali","65MK");
System.Console.WriteLine(std.GetProgra());
System.Console.WriteLine(std.GetName());
System.Console.WriteLine(std.GetYear());
System.Console.WriteLine(std.ToString());

System.Console.WriteLine($"__________________________");
var stf = new Staff("Mumtoz","46 Mk","Litseyi #1",1000);
System.Console.WriteLine(stf.GetSchool());
System.Console.WriteLine(stf.GetPay());
System.Console.WriteLine(stf.ToString()); 


