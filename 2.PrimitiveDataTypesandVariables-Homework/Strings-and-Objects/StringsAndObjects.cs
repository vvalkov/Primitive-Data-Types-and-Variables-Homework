using System;

    class StringsAndObjects
    {
        static void Main()
        {
            string h = "Hello";
            string w = "World";
            object hw = h + " " + w;
            string print = hw.ToString();
            Console.WriteLine(print);
        }
    }