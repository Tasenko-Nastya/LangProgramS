// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//int[,] MinSum(int[,] array)
//{
//    int sum = 0;
//    int index = 0;
//    int minSum = 1;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            sum = sum + array[i, j];
 //       }
//        if (sum < minSum)
//        {
//            minSum = sum;
//            index++;
//        }
//        Console.WriteLine($"строка с наименьшей суммой елементов под номером {index} с суммой элементов равной {minSum}");
//    }
///   return array; 
//}

int SumLineEl(int[,] array, int i)
{
   int sumLine = 0; 
   for (int j = 0; j < array.GetLength(1); j++)
   {
       sumLine = sumLine + array[i, j];
   }
   return sumLine;
}
void MinSum(int[,] array)
{
    int minSum = 0;
    int sumLine = SumLineEl(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int temp = SumLineEl(array, i);  
        if (sumLine > temp )
        {
            sumLine = temp;
            minSum = i+1;
        }
    }
    Console.WriteLine($"\n{minSum} строка является строкой с наименьшей суммой, равной ({sumLine})");
}


       


Console.Clear();

Console.Write("Введите количество строк массива m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 100);

PrintArray(array);
MinSum(array);




