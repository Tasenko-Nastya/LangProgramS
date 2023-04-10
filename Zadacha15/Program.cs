//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minV, int maxV){
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
       res[i] = new Random().Next(minV, maxV); 
    }
    return res;
}

int sumnech(int[] Array);{
    int sum = 0;
    int j = 0;
    
}