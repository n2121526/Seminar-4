/*Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]*/

Console.Write("Введите количество элементов в массиве: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите число, с которого начинается диапазон случайных чисел: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int numberB = int.Parse(Console.ReadLine());

void RandArray()
{
    int [] arr = new int[num];
    for(int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(numberA,numberB);
        Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine($"[{String.Join(",", arr)}]");
}
RandArray();
