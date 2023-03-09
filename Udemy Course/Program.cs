using System;

namespace Udemy_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#68 - Nullable");
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            Console.WriteLine();

            //Operador de coalescência nula
            double? a = null;
            double? b = 20;

            double? c = a ?? b;
            // It will try to set "c" as "a", but if the "a" be null, it will set the "c" as "b"

            Console.WriteLine(c);
        }
    }
}