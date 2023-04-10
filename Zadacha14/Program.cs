//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] GetArray(int size){
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
       res[i] = new Random().Next(99, 1000); 
    }
    return res;
}


int Multiple(int[] array){
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j] % 2 ==0)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");    
 Console.Write($"Количество чётных чисел в массиве: {Multiple(array)}");


