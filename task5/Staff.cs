namespace task5;

class Staff : Person
{

    string _school;
    double _pay;

    public Staff(string name, string address,string school,double pay) : base(name, address)
    {


        _school= school;
        _pay = pay;
    }

    public void SetSchool(string school)
    {
     
      _school = school;
    }

      public void SetPay(double pay)
    {
     
      _pay = pay;
    }


    public string GetSchool()
    {
    return _school;

    }

    public double GetPay()
    {
    return _pay;

    }

    public override string ToString()
    {
        return  $"{ base.ToString()}\nSkhool: {_school}\nPay: {_pay}  ";
    }
}

