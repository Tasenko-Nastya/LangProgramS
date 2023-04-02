Console.Clear();
Console.Write("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введено неправильное число");
    Console.Write("Введите пятизначное число:");
    num = int.Parse(Console.ReadLine());
}
int N = num;
int n = 0;
int x = 0;

while (num > 0)
{
        n = num % 10;
        x = x * 10 +n;
        num = num / 10;
}
Console.WriteLine(x);

if(x == N)
{
    Console.Write($" Ваше число {N} является полидромом");
}
else
{
    Console.Write($" Ваше число {N} не является полидромом");
}    