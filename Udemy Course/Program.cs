using System;

List<string> list = new List<string>() { "Ana", "Tamara", "Leticia", "Carlos", "Jairo" };

list.Add("Amanda");
list.Insert(2, "Jussara");

foreach (string obj in list)
{
    Console.WriteLine(obj);
}

Console.WriteLine();
Console.WriteLine($"List count: {list.Count()}");

Console.WriteLine();
Console.WriteLine($"First 'A': {list.Find(x => x[0] == 'A')}");

Console.WriteLine();
Console.WriteLine($"Last 'A': {list.FindLast(x => x[0] == 'A')}");

Console.WriteLine();
Console.WriteLine($"Find Index 'T': {list.FindIndex(x => x[0] == 'T')}");

Console.WriteLine();
Console.WriteLine($"Find Last Index 'A': {list.FindLastIndex(x => x[0] == 'A')}");

Console.WriteLine();
Console.WriteLine("FindAll: x[2] == 'a'");

List<string> filteredList = list.FindAll(x => x[1] == 'a');
foreach (string obj in filteredList)
{
    Console.WriteLine(obj);
}

Console.WriteLine();
Console.WriteLine("Remove Jussara");

list.Remove("Jussara");

foreach (string obj in list)
{
    Console.WriteLine(obj);
}

Console.WriteLine();
Console.WriteLine("RemoveAll");
list.RemoveAll(x => x[1] == 'a');

foreach (string obj in list)
{
    Console.WriteLine(obj);
}

Console.WriteLine();
Console.WriteLine("Remove At");

list.RemoveAt(2);

foreach (string obj in list)
{
    Console.WriteLine(obj);
}


Console.WriteLine();
Console.WriteLine("RemoveRange");

list.RemoveRange(0, 1);

foreach (string obj in list)
{
    Console.WriteLine(obj);
}