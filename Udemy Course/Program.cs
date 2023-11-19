using Udemy_Course.Entities;

namespace Udemy_Couse
{
    //delegate
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new();

            list.Add(new Product("Tv", 900));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 89.90));

            //You can do this way
            list.RemoveAll(p => p.Price >= 100);

            //Or using the predicate
            list.RemoveAll(ProductTest);


            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}
