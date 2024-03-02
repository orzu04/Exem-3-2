namespace task5;

class Student : Person
{

    string _program;
    int _year;
    double _fee;

    public Student(string program, int year, double fee, string name, string address) : base(name, address)
    {

        _program = program;
        _year = year;
        _fee = fee;

    }

    public void SetProgram(string program)
    {

        _program = program;

    }

    public void SetYear(int year)
    {

        _year = year;

    }

    public void SetFee(double fee)
    {

        _fee = fee;

    }


    public string GetProgra()
    {

        return _program;

    }

    public int GetYear()
    {

        return _year;

    }

    public double GetFee()
    {

        return _fee;

    }

    public override string ToString()
    {
        return  $" {base.ToString()}\nProgram: {_program}\nYear: {_year}\nFee: {_fee} "  ;
    }
}

