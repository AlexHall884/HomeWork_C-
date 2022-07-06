/*
Задача 25: Напишите цикл, который 
принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
Console.WriteLine("Здравствуйте, давайте возведём число А в натуральную степень числа B");
Console.WriteLine("Введите  число A: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите  число B: ");
double numberB = Convert.ToDouble(Console.ReadLine());

double result = 1;

for (int i = 0; i < numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine(result);
*/

/*
Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

/*
Console.WriteLine("Здравствуйте, эта программа показывает сумму цифр в числе.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit()
{
    int result = 0;

    while( number > 0)
    {
        result = result + number % 10; // сумма цифр равна сумма цифр + последняя цифра числа
        number = number / 10; // отбрасываем последнюю цифру числа
    }
    return result;
}

Console.WriteLine(sumDigit());
*/


/*
Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int [] numArray = new int [] {1, 2, 5, 7, 19, 6, 1, 33}; // Простой вариант без функций.

Console.WriteLine(String.Join(", ",numArray));
Console.WriteLine();

*/
/*
Console.WriteLine("Здравствуйте, эта программа поможет создать массив, заполнить элементы и вывести его на экран");
Console.WriteLine("Введите размер массива: "); // пользователь вводит размер массива.
int size = Convert.ToInt32(Console.ReadLine()); // сохраняем число равное длинне массива.
int [] numArray = new int [size]; // создаём массив где размер-это число введённое пользователем.

int [] FillArray(int [] arr) // создаём функцию заполнения массива.
{
  int length = arr.Length; // определяем длинну массива
  int i = 0; // обьявляем индекс
  while(i < length) // создаём цикл, условие: пока индекс иеньше длинны делай...
  {
    Console.WriteLine("Введите элемент массива: "); //  пользователь задаёт элеметы массива.
    arr[i] = Convert.ToInt32(Console.ReadLine());
    i++; // увеличиваем индекс на 1
  }
  return arr; // возвращаем массив
}

void PrintArray(int [] arr1) // создаём функцию вывода массива на экран.
{
  int count = arr1.Length; // счётчик равен длинне массива
  int p = 0; //  вводим позицию и присваиваем ей значения 0(с 0 отсчёт элементов в массиве).
  while (p < count - 1) // создаём цикл, который будет по очереди через запятую печатать наш массив. (-1 позволит останавиться на предпоследнем элементе и перестать печать запятую)
  {
    Console.Write(arr1[p] + ", "); // печатаем элементы через запятую
    p++; // двигаемся от элемента к элементу массива
  }
  Console.WriteLine(arr1[^1]); // выводит последний элемент массива.

}

FillArray(numArray); // вызывам функцию заполнения массива
PrintArray(numArray); // вызываем функцию вывоlа массива
*/