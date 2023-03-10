using System;

namespace Udemy_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many people?");
            int n = int.Parse(Console.ReadLine());

            double[] heightVect = new double[n]; 

            for (int i = 0; i<n; i++)
            {
                Console.Write($"What is the #{i + 1} person height?");
                heightVect[i] = double.Parse(Console.ReadLine()); 
            }

            double sum = 0;
            for (int i = 0; i<n; i++)
            {
                sum += heightVect[i];
            }
            double averageHeight = sum / n;
            Console.WriteLine($"Average Height: {averageHeight.ToString("F2")}");

            Console.WriteLine();
            Console.WriteLine("Second exercise");

            Vect2.Exercise();
        }
    }
}