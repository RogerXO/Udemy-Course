using System.Globalization;
using Udemy_Course.Entities;
using Udemy_Course.Services;

List<Product> list = new();

Console.Write("Enter N: ");
int objQuantity = int.Parse(Console.ReadLine()!);

for (int i = 0; i < objQuantity; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    list.Add(new Product(name, price));
}

Console.Write("Max: ");
Console.WriteLine(CalculationService.Max<Product>(list));