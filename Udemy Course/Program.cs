using System;

int Sum(int[] numbers) {
    int sum = 0;
    for (int i  = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

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
