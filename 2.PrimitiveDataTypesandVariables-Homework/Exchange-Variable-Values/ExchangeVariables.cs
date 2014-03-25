using System;

class ExchangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Beofre exchange: {0} {1}", a, b);
        a = a + b; // 5 + 10 = 15
        b = a - b; // 15 - 10 = 5
        a = a - b; // 15 - 5 = 10
        Console.WriteLine("After exchange: {0} {1}", a, b);

    }
}
