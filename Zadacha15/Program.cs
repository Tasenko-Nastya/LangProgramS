//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minV, int maxV){
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
       res[i] = new Random().Next(minV, maxV+1); 
    }
    return res;
}

int Sumnech(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j+=2)
    {
       sum = sum + array[j]; 
    }
    return sum;
}

int[] array = GetArray(5, 0, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");    
 Console.Write($"Сумма элементов, стоящих на нечётных позициях в массиве: {Sumnech(array)}");