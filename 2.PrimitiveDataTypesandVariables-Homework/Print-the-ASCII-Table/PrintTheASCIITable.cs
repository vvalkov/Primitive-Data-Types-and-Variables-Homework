using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 32; i < 256; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();
    }
}
