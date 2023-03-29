Console.Clear();
Console.Write("Введите значения a:");
int a = int.Parse(Console.ReadLine());
int n = 0;
if (a>99)
{
    while (a>999)
    {
        a = a / 10;
    }
    n = a % 10;
    Console.WriteLine($"{n}");
}    
else
{
    Console.WriteLine($"Третьей цифры нет");    
}
