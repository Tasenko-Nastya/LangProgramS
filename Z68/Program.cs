// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите положительное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное число n: ");
int n = int.Parse(Console.ReadLine()!);
Akkermanfunction(n, m);
Console.WriteLine($" Функция Аккермана для элементов {m} и {n} равна {Akkermanfunction(m, n)}");

int Akkermanfunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkermanfunction(m - 1, 1);
    }
    return Akkermanfunction(m - 1, Akkermanfunction(m, n - 1));
}
