// Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива. 
//[3 7 22 2 78] -> 76

double[] GetArray(int size, int min, int max){
   double[] res = new double [size];
    for (int i = 0; i < size; i++)
    {
       //res[i] = new Random().Next(min, max+1);
       double N = new Random().NextDouble()*(max - min) + min;
       res[i] = Math.Round(N, 1);
    }
    return res;
}
double Subtraction(double[] array){
    double max =   array[0];
    double min =   array[0];
    for (int j = 0; j < array.Length; j++){
        if(array[j] > max)
        {
            max = array[j];
        }
        if(array[j] < min)
        {
           min = array[j];
        }
    }
    return max - min;
}

double[] array = GetArray(5, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");  
Console.Write($"Разница равна {Subtraction(array)}");


