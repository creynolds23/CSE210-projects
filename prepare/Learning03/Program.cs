using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction t = new Fraction();
        t.SetFractionTop(5);
        Fraction fraction2 = new Fraction(t.GetFractionBottom());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction t2 = new Fraction();
        t2.SetFractionTop(3);
        Fraction b2 = new Fraction();
        b2.SetFractionBottom(4);
        Fraction fraction3 = new Fraction(t2.GetFractionTop(), b2.GetFractionBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction t3 = new Fraction();
        t3.SetFractionTop(1);
        Fraction b3 = new Fraction();
        b3.SetFractionBottom(3);
        Fraction fraction4 = new Fraction(t3.GetFractionTop(), b3.GetFractionBottom());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}