using System;
using Microsoft.Win32;


class Complex
{
    public double Realna;
    public double Imaginarni;
    public Complex(double realna = 0.0, double imaginarni = 0.0)
    {
        Realna = realna;
        Imaginarni = imaginarni;
    }
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Realna + b.Realna, a.Imaginarni + b.Imaginarni);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Realna - b.Realna, a.Imaginarni - b.Imaginarni);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex((a.Realna * b.Realna - a.Imaginarni * b.Imaginarni), a.Realna * b.Imaginarni + a.Imaginarni * b.Realna);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        double power = 2;
        return new Complex(((a.Realna * b.Realna + a.Imaginarni * b.Imaginarni)/(Math.Pow(b.Realna,power)+Math.Pow(b.Imaginarni, power))),
            ((a.Imaginarni * b.Realna - a.Realna * b.Imaginarni)/(Math.Pow(b.Realna, power) + Math.Pow(b.Imaginarni, power))));
    }


    public override string ToString()
    {
        if (Imaginarni < 0)
        {
            return string.Format("{0}-{1}j", Realna, -Imaginarni);
        }
        else
        {
            return string.Format("{0}+{1}j", Realna, Imaginarni);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex x = new Complex(1.2, 0.5); // vytvoření instance třídy
        Complex y = new Complex(2.0, -1.5); // vytvoření instance třídy
        Console.WriteLine("Soucet komplexních cisel");
        Console.WriteLine(x + y);
        Console.WriteLine("---------------");
        Console.WriteLine("Rozdíl komplexních cisel");
        Console.WriteLine(x - y);
        Console.WriteLine("---------------");
        Console.WriteLine("Násobení komplexních cisel");
        Console.WriteLine(x * y);
        Console.WriteLine("---------------");
        Console.WriteLine("Dělení komplexních cisel");
        Console.WriteLine(x / y);
        Console.WriteLine("---------------");
        Console.ReadLine();
    }
}
