//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11, 82 -> 10, 9012 -> 12
int Sum(int a){
    int b = 0;
    int c = 0;
    int n = 0;
    for (int i = 0; i <= a; i++)
    {
        b = a % 10;
        a = a / 10;
        n = n + b;
    }
    return n;
}
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
 Console.WriteLine($"{Sum(a)}");
