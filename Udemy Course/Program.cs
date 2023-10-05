// HashSet is ultra fast but has no itens order
HashSet<string> set = new();

set.Add("Mouse");
set.Add("Keyboard");
set.Add("Gaming chair");

Console.WriteLine(set.Contains("Monitro"));

set.Add("Mouse");

foreach (string element in set)
{
    Console.WriteLine(element);
}

// SortedSet is fast and your itens order follow IComparer<T> implementation
SortedSet<int> par = new() { 0,2,4,6,8,10 };
SortedSet<int> impar = new() { 1, 3, 5, 7, 9 };
PrintCollection(par);

// union
SortedSet<int> union = new(par);
union.UnionWith(impar);
PrintCollection(union);

// intersection 
SortedSet<int> intersection = new(par);
intersection.IntersectWith(impar);
PrintCollection(intersection);

// difference
SortedSet<int> remove = new(par);
remove.ExceptWith(impar);
PrintCollection(remove);

void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
