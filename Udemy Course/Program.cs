using Udemy_Course.Entities;

HashSet<Product> products = new();
products.Add(new Product("TV", 900));
products.Add(new Product("Notebook", 1200));

Product prod = new("Notebook", 1200);
// If the reference type Product doesnt implements GetHashCode and Equals it will return false because in this case HashSet will compare the object memory reference, and as they are two differents instanced values they have two differents memory reference.
// But if GetHashCode and Equals methods are implementeds in Product, HashSet will compare the content
Console.WriteLine(products.Contains(prod));


HashSet<Point> points = new();
points.Add(new Point(1, 2));
points.Add(new Point(5, 10));

Point point = new(5,10);
Console.WriteLine(points.Contains(point));
// Point was implemented as struct and in this case the HashSet compare the itens content