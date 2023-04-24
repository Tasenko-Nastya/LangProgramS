// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите положительное число n: ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;
WriteNumber( n,  i);



void WriteNumber(int n, int i)
{
    if(i >  n) return;
    WriteNumber( n,  i + 1);
    Console.Write( i + ",");
    
    
}
