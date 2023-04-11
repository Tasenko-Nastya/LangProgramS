//  Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2, 1, -7, 567, 89, 223-> 3

int[] ArrayString( string StrArray )
{
    string[] N = StrArray.Split(",");
    int[] res = new int[N.Length];
    for (int i = 0; i < N.Length; i++)
    {
        res[i] = int.Parse(N[i]);
    }
    return res;
}
int PositivN(int[] array){
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j] > 0)
        count++;
    }
    return count;
}
Console.Write("Введите числа через запятаю: ");
string elements = Console.ReadLine();
int[] array = ArrayString(elements);
Console.Write($"Количество положительных чисел: {PositivN(array)}");
