Console.Clear();
Console.Write("Введите значения a:");
int a = int.Parse(Console.ReadLine());
int b = a % 100;
int c = a % 10;
int d = (b-c)/10;
Console.WriteLine(d);
