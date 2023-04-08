//Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵) //2, 4 -> 16

int Exponentiation(int a, int b){
    int exp = 1;
    for (int i = 1; i <= b; i++)
    {
        exp = exp*a;
    }
    return exp;
}
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
 Console.WriteLine($"{Exponentiation( a, b)}");
