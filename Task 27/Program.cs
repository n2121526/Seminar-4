/*Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int SumCount (int a)
{ 
    int count = 0;
    int result = 0;
    while (a != 0)
    {
        count++;
        result += a % 10;
        a /= 10;
    }
    return result;
}
Console.WriteLine(SumCount(num));
