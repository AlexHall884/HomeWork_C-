/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
Console.WriteLine("Здравствуйте, эта программа посчитает сколько чисел больше 0 вы ввели.");
Console.WriteLine("Сколько чисел вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());
int[] numArray = new int[size];

int[] FillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    int q = 0;
    while (i < length)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return arr;
}

int GetResult(int[] arr1)
{
    int length = arr1.Length;
    int i = 0;
    int count = 0;
    while (i < length)
    {
        if (arr1[i] > 0) count++;
        i++;
    }
    return count;
}

FillArray(numArray);
Console.WriteLine(String.Join(", ", numArray));
Console.WriteLine("Кол-во чисел больше 0 будет = " + GetResult(numArray));
*/

/*
Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
Console.WriteLine("Доброго времени суток, эта программа поможет найти точку пересечения двух прямых.");
Console.WriteLine("Для этого нужно решить уровнения: y = k1 * x + b1 и y = k2 * x + b2");
Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = (k2*b1-k1*b2)/(k2-k1);

Console.WriteLine("Точка пересечения двух прямых = " + x + "," + y);
*/