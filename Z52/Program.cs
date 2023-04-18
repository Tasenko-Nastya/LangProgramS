//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SrArif(int[,] array)
{
        for (int j = 0; j < array.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum = sum + array[i, j];
        }
    Console.WriteLine($" Среднее арифмитическое {Math.Round(sum/array.GetLength(0), 1)}");
    }
}    
     
Console.Clear();

Console.Write("Введите количество строк массива m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 100);

PrintArray(array);
SrArif(array);
