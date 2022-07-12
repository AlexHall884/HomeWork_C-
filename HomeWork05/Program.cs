/*
Задача 34: Задайте массив, 
заполненный случайными положительными 
трёхзначными числами. 
Напишите программу, которая 
покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] FillArray(int[] arr) // создаём функцию заполнения массива.
{
    int length = arr.Length; // определяем длинну массива
    int i = 0; // обьявляем индекс
    while (i < length) // создаём цикл, условие: пока индекс меньше длинны делай...
    {
        arr[i] = new Random().Next(100, 1000); // заполняем массив случайными числами
        i++; // увеличиваем индекс на 1
    }
    return arr; // возвращаем массив
}

int EvenNumbers(int[] arr1)
{
    int length = arr1.Length; // длинна массива
    int count = 0; // колличество чётных чисел
    int i = 0; // счётчик
    while (i < length)
    {
        if (arr1[i] % 2 == 0)
        {
            count = count + 1;
        }
        i++;
    }
    return count; // возвращаем кол-во чётных чисел
}

int[] numArray = new int[8];
FillArray(numArray);
Console.WriteLine(String.Join(" ", numArray)); // Выводим массив
Console.WriteLine("Количество чётных чисел в массиве = " + EvenNumbers(numArray));
*/

/*
Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] FillArray(int[] arr)
{
    int length = arr.Length;
    int i = 0;
    while (i < length)
    {
        arr[i] = new Random().Next(1, 10);
        i++;
    }
    return arr;
}

int SumNeg(int[] arr1)
{
    int length = arr1.Length;
    int i = 0;
    int sum = 0;
    while (i < length)
    {
        if (i % 2 != 0) // если остаток от деления не равен нулю, то складываем сумму (i%2 != нечётное число)
        {
            sum = sum + arr1[i];
        }
        i++;
    }
    return sum;
}

int[] numArray = new int[5];
FillArray(numArray);
Console.WriteLine(String.Join(" ", numArray));
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + SumNeg(numArray));
*/

/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальных и минимальных элементов массива.
[3 7 22 2 78] -> 76
*/
/*
double [] FillArray(double [] arr) 
{
  int length = arr.Length; 
  int i = 0; 
  while(i < length) 
  {
    arr[i] = new Random().Next(1,100) / 10.0; 
    i++; 
  }
  return arr; 
}
double FindDif (double [] arr1)
{
    int length = arr1.Length;
    int i = 0;
    double max = arr1[i];
    double min = arr1[i];
    while(i < length)
    {
      if(arr1[i] > max) max = arr1[i];
      if(arr1[i] < min) min = arr1[i];
      i++;
    }
    double dif = max - min;
    return dif;
}

double [] numArray = new double [8];
FillArray(numArray);
Console.WriteLine(String.Join("|",numArray));
Console.WriteLine("Разница = " + FindDif(numArray));
*/