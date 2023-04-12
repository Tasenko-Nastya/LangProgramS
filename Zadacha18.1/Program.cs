// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
 

Console.WriteLine($"две прямые пересекутся в точке с координатами: {String.Join(", ", Intersections( b1, k1, b2, k2))}");


double[] Intersections( double b1, double k1, double b2, double k2){
    double[] kor = new double[2];
    kor [0] = ( b1 - b2 )/(k2 - k1);
    kor [1] = (k2 * kor[0] + b2);
    return kor;
}
