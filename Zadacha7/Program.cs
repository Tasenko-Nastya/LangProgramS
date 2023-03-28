Console.Clear();
Console.Write("Введите номер недели: ");
int numberDay = int.Parse(Console.ReadLine());
while(numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("Введен неправильный номер");
    Console.Write("Введите номер недели: ");
    numberDay = int.Parse(Console.ReadLine());
}
if (numberDay > 5 && numberDay < 8)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний день");
}