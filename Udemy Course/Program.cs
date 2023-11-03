using Udemy_Course.Entities;

List<Product> list = new();

list.Add(new Product("Tv", 900));
list.Add(new Product("Notebook", 1200));
list.Add(new Product("Tablet", 450));

list.Sort();

foreach(Product item in list) {
    Console.WriteLine(item);
}