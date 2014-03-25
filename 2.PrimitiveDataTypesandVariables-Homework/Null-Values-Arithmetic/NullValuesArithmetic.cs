using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            a += 2;
            b += 3;
            Console.WriteLine(a + b);
        }
    }