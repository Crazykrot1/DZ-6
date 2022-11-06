                               
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("Введите значения b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k2 - k1);
double y = x * k1 + b1;

Console.WriteLine($"точку пересечения x={x}, y={y} ");

*/ 






// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите ряд чисел через пробел:");
int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Mass(array);

int Mass(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел равно: {count}");
    return count;
}
                         



