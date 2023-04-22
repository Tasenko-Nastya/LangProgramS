// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void GetMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }

    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ResultMatrix(int[,] onematrix, int[,] twomatrix, int[,] threematrix)
{
    for (int i = 0; i < threematrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < threematrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int z = 0; z < onematrix.GetLength(1); z++)
            {
                sum = sum + onematrix[i, z] * twomatrix[z, j];
            }
            threematrix[i, j] = sum;
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк 1-ой матрицы m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1-ой матрицы  n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2-ой матрицы k: ");
int k = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2-ой матрицы  l: ");
int l = int.Parse(Console.ReadLine()!);
int[,] onematrix = new int[m, n];
GetMatrix(onematrix);
PrintMatrix(onematrix);
Console.WriteLine();
int[,]twomatrix = new int[k,l];
GetMatrix(twomatrix);
PrintMatrix(twomatrix);
Console.WriteLine();
int[,]threematrix = new int[m,l];
if (n != k)
{
    Console.Write("умножение невозможно");
}
else
{
    ResultMatrix(onematrix, twomatrix, threematrix);
    Console.WriteLine($" произведение первой и второй матриц:");
    PrintMatrix(threematrix);
}

