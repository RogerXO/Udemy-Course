using Udemy_Course.Entities;

static void Print<T>(string message, IEnumerable<T> list)
{
    Console.WriteLine($"- {message} -");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}

Category c1 = new(1, "Tools", 2);
Category c2 = new(2, "Computers", 1);
Category c3 = new(3, "Electronics", 1);

List<Product> products = new()
{
    new(1, "Computer", 1100, c2),
    new(2, "Hammer", 90, c1),
    new(3, "TV", 1700, c3),
    new(4, "Notebook", 1300, c2),
    new(5, "Saw", 80, c1),
    new(6, "Tablet", 700, c2),
    new(7, "Camera", 700, c3),
    new(8, "Printer", 350, c3),
    new(9, "MacBook", 1800, c2),
    new(10, "Sound Bar", 700, c3),
    new(11, "Level", 70, c1),
};

IEnumerable<Product> r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
Print("Tier 1 and price < 900", r1);

IEnumerable<string> r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
Print("Names of product from Tools", r2);

var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
Print("Names started with 'c' and anonymous object", r3);

IEnumerable<Product> r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
Print("Tier 1 ordered by price then by name", r4);

IEnumerable<Product> r5 = r4.Skip(2).Take(4);
Print("Tier 1 ordered by price then by name, skip 2 take 4", r5);

// Single() method returns the only element of a sequence and throw an exception if there is more than one in the sequence or if it be empty
// var r6 = products.Where(p => p.Price > 30000).Single();
// Console.WriteLine(r6);

Product? r6 = products.FirstOrDefault();
Console.WriteLine("First or default test1: " + r6);

Product? r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
Console.WriteLine("First or default test2: " + r7);

Console.WriteLine();

var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("Single or default test1: " + r8);

Product? r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test2:" + r9);

Console.WriteLine();

double r10 = products.Max(p => p.Price);
Console.WriteLine("Max price: " + r10);

double r11 = products.Min(p => p.Price);
Console.WriteLine("Min price: " + r11);

double r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 Sum prices: " + r12);

double r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Average prices: " + r13);

double r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Category 5 Average prices: " + r14);

double r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((prev, cur) => prev + cur);
Console.WriteLine("Category 1 aggregate sum: " + r15);

Console.WriteLine();

IEnumerable<IGrouping<Category, Product>> r16 = products.GroupBy(p => p.Category);

foreach (IGrouping<Category, Product> group in r16)
{
    Console.WriteLine("Category " + group.Key.Name + ":");
    foreach(Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}
