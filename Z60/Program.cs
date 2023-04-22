// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

int[, ,] GetArray(int[] size, int min, int max)
{
    int[, ,] result = new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
           for (int k = 0; k < result.GetLength(2); k++)
           {
            int element = new Random().Next(min, max + 1);
            if (FindElement(result, element)) 
            continue;
            result[i, j, k] = element;
           } 
        }
    }
    return result;
}

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) 
                return true;
            }
        }
    }
    return false;
}

void PrintArray(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
            Console.Write($"{array[i, j, k]} ({i} {j} {k}) ");
           } 
           Console.WriteLine();
        }
    }
    
}

Console.Clear();
Console.Write("Введите x, y, z через пробел: ");
string[] xyz = Console.ReadLine()!.Split(" ");
int a = int.Parse( xyz[0]);
int b = int.Parse( xyz[1]);
int c = int.Parse( xyz[2]);
int[, ,] array = GetArray(new int[] {a, b, c}, 10, 99);
PrintArray(array);
