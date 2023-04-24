// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите положительное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное число n: ");
int n = int.Parse(Console.ReadLine()!);
Summa(n, m);
Console.WriteLine($" Сумма элементов между {m} и {n} равна {Summa(m, n)}");


int Summa(int mn, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + Summa(m,  n - 1);
    
}
