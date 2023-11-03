using Udemy_Course.Entities;

List<Product> list = new();

list.Add(new Product("Tv", 900));
list.Add(new Product("Notebook", 1200));
list.Add(new Product("Tablet", 450));

list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach(Product item in list) {
    Console.WriteLine(item);
}

