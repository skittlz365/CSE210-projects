using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction1 = new Fraction();
        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetDecimalValue());

        Fraction myFraction2 = new Fraction(6);
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetDecimalValue());     

        Fraction myFraction3 = new Fraction(4,9);
        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetDecimalValue());    

        Fraction myFraction4 = new Fraction();
        Random random = new Random();

        for(int i = 0; i<20; i++)
        {
            int npTopValue = random.Next(1,11);
            int npBottomValue = random.Next(1,11);
            myFraction4.SetTop(npTopValue);
            myFraction4.SetBottom(npBottomValue);
            Console.Write($"Fraction {i+1} ");
            Console.Write($"string: {myFraction4.GetFractionString()}, ");
            Console.WriteLine($"Decimal: {myFraction4.GetDecimalValue()}");
        }

    }
}