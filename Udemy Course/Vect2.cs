using System;

namespace Udemy_Course
{
    class Vect2
    {
        public static void Exercise()
        {
            Console.Write("How many products do you want? ");
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("What is the product name? ");
                string productName = Console.ReadLine();
                Console.Write("And it's price? ");
                double productPrice = double.Parse(Console.ReadLine());
                products[i] = new Product(productName, productPrice);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }
            double averagePrice = sum / n;

            Console.WriteLine();

            Console.WriteLine($"Average price: {averagePrice:F2}");
        }
    }
}
