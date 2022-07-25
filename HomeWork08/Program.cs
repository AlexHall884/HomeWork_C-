/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

/*
int rows = 3;
int column = 4;

int[,] FillArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}| ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(1) - 1; k++)
            {
                if (newArray[i, k] > newArray[i, k + 1])
                {
                    int temp = newArray[i, k + 1];
                    newArray[i, k + 1] = newArray[i, k];
                    newArray[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = FillArray(rows, column);
printArray(array);
SortArray(array);
Console.WriteLine();
printArray(array);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
int rows = 4;
int column = 4;

int[,] FillArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSum(int[,] newArray)
{
    int min = 0;
    int sum1 = int.MaxValue;
    int sum2 = 0;
    int row = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        sum2 = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum2 = sum2 + newArray[i, j];
        }
        if (sum2 < sum1)
        {
            min = sum2;
            row = i;
        }
        sum1 = sum2;
    }
    Console.WriteLine("Минимальная сумма находится в " + row + " строке и равна -> " + min);
}

int[,] array = FillArray(rows, column);
printArray(array);
MinSum(array);
*/

/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая 
будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

/*
int rows1 = 3;
int column1 = 3;
int rows2 = 3;
int column2 = 3;

int[,] FillArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for(int k = 0; k < secondMatrix.GetLength(0); k++)
            {
            resultMatrix [i,j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    } 
    return resultMatrix;
} 

int[,] matrix1 = FillArray(rows1, column1);
int[,] matrix2 = FillArray(rows2, column2);

printArray(matrix1);
Console.WriteLine("и");
printArray(matrix2);
Console.WriteLine();
MatrixProduct(matrix1, matrix2);
int[,] result = MatrixProduct(matrix1, matrix2);
printArray(result);
*/

/*
Задача 60. Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

/*
int rows = 2;
int columns = 2;
int page = 2;

void GetArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int r = 0; r < array3D.GetLength(0); r++)
    {
        for (int c = 0; c < array3D.GetLength(1); c++)
        {
            for (int p = 0; p < array3D.GetLength(2); p++)
            {
                array3D[r, c, p] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"| {inArray[i, j, k]} -> {(i, j, k)} |");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array1 = new int[rows, columns, page];
GetArray(array1);
PrintArray(array1);
*/

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

int rows = 4;
int columns = 4;

int[,] SpiralArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] / 10 <= 0) Console.Write($" {inArray[i, j]} ");
            else Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = SpiralArray(rows, columns);
PrintArray(matrix);



