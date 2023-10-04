using Udemy_Course;

Console.Write("How many values? ");
int x = int.Parse(Console.ReadLine());

PrintService printService = new();

for (int i = 0; i < x; i++)
{
    int value = int.Parse(Console.ReadLine());
    printService.AddValue(value);
}

printService.Print();
Console.WriteLine($"First: {printService.First()}");


