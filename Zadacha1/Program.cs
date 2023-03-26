Console.Clear();
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());

if (a>b) 
{
    Console.WriteLine($"{a} большее число, {b} меньшее число");
}
else
{
    Console.WriteLine($"{b} большее число, {a} меньшее число");
}
