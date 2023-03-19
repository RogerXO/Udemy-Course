using System;

int Sum(int[] numbers) {
    int sum = 0;
    for (int i  = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

//By using the params keyword, you can specify a method parameter that takes a variable number of arguments. The parameter type must be a single-dimensional array.
int SumWithParams(params int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

Console.WriteLine(Sum(new int[] { 1, 2, 3 }));
Console.WriteLine(SumWithParams(1, 2, 3));
