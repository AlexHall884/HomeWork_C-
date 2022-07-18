/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
Console.WriteLine("Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] intArray = new double[m, n];

void FillArray()
{

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(-100,100) / 10.0;
        }
    }

}

void printArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            Console.Write(intArray[i, j] + "| ");

        }
        Console.WriteLine();

    }
}

FillArray();
printArray();
*/

/*
Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/*
Console.WriteLine("Здравствуйте, эта программа задаёт двумерный массив m*n и позволяет определить есть ли в нём, нужное вам число.");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое хотите найти: ");
int digit = Convert.ToInt32(Console.ReadLine());
int[,] intArray = new int[m, n];

void FillArray()
{

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(1, 21);
        }
    }

}
void PrintArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            Console.Write(intArray[i, j] + "| ");

        }
        Console.WriteLine();

    }
}

string FindDigit(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[i, j] == digit) return "Такое число есть";
        }
    }
    return "Такого числа нет ";
}

FillArray();
PrintArray();
Console.WriteLine(digit + " -> " + FindDigit(intArray));
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*
int m = 3;
int n = 4;
int[,] intArray = new int[m, n];

void FillArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            intArray[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(intArray[i, j] + "| ");
        }
        Console.WriteLine();
    }
}

void FindAverage()
{
    double average = 0;
    int column = 0;
    for (int j = 0; j < n; j++)
    {
        column++;
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum = sum + intArray[i, j];
        }
        average = sum / m;
        Console.WriteLine("Среднее арифметичское " + column + " столбца -> " + Math.Round(average, 1));
    }
}

FillArray();
PrintArray();
FindAverage();

*/
