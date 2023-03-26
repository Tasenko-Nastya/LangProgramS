Console.Clear();
Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine());
for (int i = 2; i < n+1; i++)
{
 if (i % 2 ==0)
 {
    Console.Write($"{i}");
    
 }
}

