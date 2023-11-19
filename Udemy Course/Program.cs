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

            Action<Product> act = UpdatePrice;
            Action<Product> act1 = p => { p.Price += p.Price * 0.1; };

            //There are many ways of to pass an Action<>, see they above:
            list.ForEach(UpdatePrice);
            //list.ForEach(act);
            // list.ForEach(act1);
            //list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
