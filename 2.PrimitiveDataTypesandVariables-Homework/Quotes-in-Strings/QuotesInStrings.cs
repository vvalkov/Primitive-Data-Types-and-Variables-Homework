using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string quoted = "The \"use\" of quotations causes difficulties.";
            string notQuoted = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quoted + "\n" + notQuoted);
        }
    }
