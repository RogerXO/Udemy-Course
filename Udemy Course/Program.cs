using Udemy_Course.Entities;

namespace Udemy_Couse
{
    //delegate
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new()
            {
                new Product("Tv", 900),
                new Product("Mouse", 50),
                new Product("Tablet", 350),
                new Product("HD Case", 89.90)
            };

            Func<Product, string> func = NameUpper;
            Func<Product, string> func1 = p => p.Name.ToUpper();


            // List<string> result = list.Select(NameUpper).ToList();
            // List<string> result = list.Select(func).ToList();
            //List<string> result = list.Select(func1).ToList();
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();


            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
