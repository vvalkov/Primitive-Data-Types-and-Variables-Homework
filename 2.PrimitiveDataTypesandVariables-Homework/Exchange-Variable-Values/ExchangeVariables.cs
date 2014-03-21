using System;

class ExchangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Beofre exchange: {0} {1}", a, b);
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
        Console.WriteLine("After exchange: {0} {1}", a, b);

    }
}
