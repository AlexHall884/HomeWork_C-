/*
Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
/*
// Решение без рекурсии
Console.WriteLine("Эта программа покажет все натуральные числа от M до N.");
Console.WriteLine("Задайте значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void FindNumber(int  m, int n)
{
    for(int i = m; i <= n; i++)
    {
        Console.Write(i + ", ");
    }
}
FindNumber(numberM, numberN);
*/

// Решение с рекурсией
/*
string FindNumber( int m, int n)
{
 if( m == n) return n.ToString();
   else return m.ToString() + ", " + FindNumber(m+=1, n);
}

Console.WriteLine(FindNumber(4,8));
*/

/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// Решение без рекурсии
/*
Console.WriteLine("Эта программа покажет сумму натуральных чисел от M до N.");
Console.WriteLine("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = (n*(n + 1))/2 - ((m-1)*((m-1) + 1))/2;
Console.WriteLine("Сумма натуральных чисел от " + m + " до " + n + " -> " + sum);
*/

// Решение с рекурсией

/*
int FindSum( int m, int n)
{
 if( m == n) return n;
   else return m + FindSum(m+=1, n);
}

Console.WriteLine(FindSum(1,15));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
/*
Console.WriteLine("Эта программа вычисляет функцию Аккермана.");
Console.WriteLine("Задайте значение M: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

int AckermanFuncion(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFuncion(m - 1, 1);
    return AckermanFuncion(m - 1, AckermanFuncion(m, n - 1));
}

Console.WriteLine(AckermanFuncion(mNumber, nNumber));
*/