// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07



int[,] GetArray(int m, int min, int max)
{
    int[,] result = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
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
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] Spiral(int[,] array)
{
          
    int a = 1;
    int i = 0;
    int j = 0;
    while (a <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = a;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                ++j;
            else if (i < j && i + j >= array.GetLength(0) - 1)
                ++i;
            else if (i >= j && i + j > array.GetLength(1) - 1)
                --j;
            else
                --i;
            ++a;
        } 
    return array;
}    
    

Console.Clear();
Console.Write("Введите количество строк массива m: ");
int m = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(m, 0, 10);
Console.WriteLine();
Spiral( array ); 
PrintArray(array);