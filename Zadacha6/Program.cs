Console.Clear();
Console.Write("Введите значения a:");
int a = int.Parse(Console.ReadLine());
int n = 0;
while (a>99)
{
    if (a<1000)
    {
        n = a % 10;
        Console.WriteLine($"{n}");
    }
    else
    {
    a = a % 10;
    }
}    
if (a<100)
{
    Console.WriteLine($"Третьей цифры нет");    
}
