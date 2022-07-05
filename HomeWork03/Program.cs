/* Задача 19
Напишите программу, которая принимает 
на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Console.WriteLine("Здравствуйте, эта программа проверяет является ли число полиндромом.");
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


while(number > 99999 || number < 10000)
{
    Console.WriteLine("Число не является пятизначным.");
    Console.WriteLine("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());       
}

string palindrome(int num)
{
    int rev = 0;
    int copyNumber = number;
    while(num != 0)
    {
        int r = num % 10;
        rev = rev * 10 + r;
        num = num / 10;
    }
    if(copyNumber == rev)
    {
        return " число явлеятся полиндромом";
    }
    else
    {
        return " число не является полиндромом";
    }
}
Console.WriteLine(number + palindrome(number));
*/

/* 
Задача 21
Напишите программу, которая принимает на вход 
координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Console.WriteLine("Доброго времени суток!");
Console.WriteLine("Эта программа находит расстояние между двумя точками в 3D пространстве");

double EuclideanDistance()
{
    Console.WriteLine("Введите координаты первой точки: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки:  ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + (Math.Pow(z1-z2, 2))); 
    
    return distance;

}

Console.WriteLine("Расстояние между точками = " + Math.Round(EuclideanDistance(), 2));
*/

/*
Задача 23
Напишите программу, которая 
принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
Console.WriteLine("Hello! Эта программа показывает таблицу кубов от 1 до заданного числа");
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

string findCube()
{
    int cube = 0;
 
    for (int i = 1; i <= n; i++)
    {
        cube = i * i * i;
        Console.Write(cube + ", ");
    }
    return  "";
}

Console.WriteLine(findCube());

*/
