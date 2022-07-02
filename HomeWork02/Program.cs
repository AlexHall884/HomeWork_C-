/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/


/*Console.WriteLine("Доброго времени суток.");
Console.WriteLine("Эта программа показывает вторую цифру трёхзначного числа.");
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int function (int symbol2){
    symbol2 = number%100/10;
    return symbol2;
}
Console.WriteLine("Вторая цифра числа " + number + ": " + function(number));
*/

/*Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*Console.WriteLine("Здравствуйте.");
Console.WriteLine("Эта программа показывает третью цифру  числа.");
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();     

string function(){
    string[] num = new string [number.Length];
    if(number.Length <= 2){
        return "Третьей цифры нет";
    }else{
        return "Третья цифра числа " + number + ": " + number[2];
    }

};
Console.WriteLine(function());
*/


/*Задача 15: Напишите программу, которая 
принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*string function(){
    Console.WriteLine("Здравствуйте.");
Console.WriteLine("Эта программа показывает является ли день недели выходным или нет.");
Console.WriteLine("Введите день недели с помощью цифр: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 7){
    Console.WriteLine("В неделе 7 дней");
    Console.WriteLine("Введите число от 1 до 7: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if(number <= 5){
    return "Это будний день";
}
else{
    return "Этот день выходной";
}

};

Console.WriteLine(function());
*/
