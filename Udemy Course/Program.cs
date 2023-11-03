using Udemy_Course.Entities;

List<Product> list = new();

list.Add(new Product("Tv", 900));
list.Add(new Product("Notebook", 1200));
list.Add(new Product("Tablet", 450));

Comparison<Product> comp = CompareProducts;

list.Sort(comp);

foreach(Product item in list) {
    Console.WriteLine(item);
}

static int CompareProducts(Product p1, Product p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}
