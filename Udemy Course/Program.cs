using System;

int n = int.Parse(Console.ReadLine());

int[,] matriz = new int[n,n];

for(int i = 0; i <n; i++)
{
    string[] values = Console.ReadLine().Split(' ');
 
    for (int j = 0; j < n; j++)
    {
        matriz[i,j] = int.Parse(values[j]);
    }
}

Console.WriteLine("Main diagonal: ");
for  (int i = 0;i < n; i++)
{
    Console.Write($"{matriz[i,i]} ");
}

int NegativeNumbers = 0;

for (int i = 0; i < n ; i++)
{
    for (int j = 0;j < n ; j++)
    {
        if (matriz[i,j] < 0)
        {
            NegativeNumbers++;
        }
    }
}

Console.WriteLine();
Console.Write($"Negative numbers: {NegativeNumbers}");