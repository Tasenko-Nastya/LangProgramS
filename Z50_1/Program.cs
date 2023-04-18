// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4 17 -> такого числа в массиве нет

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            double num = new Random().NextDouble() * (max - min) + min;
            result[i, j] = Math.Round(num, 1);
        }

    }
    return result;
}

void PrintArray(double[,] array)
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

void PrintAr(double[,] array)
{
    Console.Write("Введите позицию строки: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите позицию столбца: ");
    int n = int.Parse(Console.ReadLine()!);
        
        if (m > array.GetLength(0) || n > array.GetLength(1))
        {
            Console.WriteLine ("Такого элемента нет");
        }
        else
        {
            Console.WriteLine($" Значение элемента равно {array [m-1 , n-1]}");
        }
        
}
   

Console.Clear();

Console.Write("Введите количество строк массива m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(m, n, 0, 100);

PrintArray(array);

PrintAr(array);
