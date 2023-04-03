using System;

// (condition) ? value if true : value if false

double price = double.Parse(Console.ReadLine());

double discont = (price < 20) ? price * 0.1 : price * 0.05;

Console.WriteLine($"{discont:F2}");