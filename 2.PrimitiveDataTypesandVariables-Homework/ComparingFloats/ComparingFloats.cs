using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
            float firstValue;
            float secondValue;
            double eps = 0.000001;
            Console.WriteLine("Insert a floating number 1:");
            firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert a floating number 2:");
            secondValue = float.Parse(Console.ReadLine());
            if (Math.Abs((decimal)(secondValue - firstValue)) >= (decimal)eps)
            {
                Console.WriteLine("The numbers are different");
            }
                
            else
            { 
                Console.WriteLine("The numbers are equal (with precision 0.000001)");
            }
        }
    }
