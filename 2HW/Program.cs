
/// 2 homework
/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
//////////////////
/*
int Pack(int num)

{
    int a;
    a = num/10%10;
    return a;
}

Console.WriteLine("input digit");
int num = Convert.ToInt32(Console.ReadLine());
int res = Pack(num);

Console.WriteLine($"{res} is 2-digit number of {num} ");

*/



/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/////////////////////////


// РЕШЕНИЕ НЕ СОВСЕМ ПРАВИЛЬНОЕ: ИЩУ ТРЕТЬЮ С КОНЦА ЦИФРУ
/*
void FindNum(int a)
{
    int  hund, b, c;
    hund = a%1000;
    b = hund%10; 
    c = hund/100;
    while (a > 999)
    {
        a = a / 10;
    }   
    if(a<=99)
        Console.WriteLine("a третьей цифры-то нет!");
    if((a>100)&&(a<1000))
        Console.WriteLine($"третья цифра {b}");
    if(a>999)
        Console.WriteLine($"третья цифра {c}");
}

Console.WriteLine("input a");
int x = Convert.ToInt32(Console.ReadLine());

FindNum(x);
*/

////////////////////////////////////////////////
// ПРАВИЛЬНОЕ РЕШЕНИЕ: ТРЕТЬЯ ЦИФРА СЛЕВА ДЛЯ ЧИСЕЛ ЛЮБОЙ РАЗРЯДНОСТИ
// НЕ ИСКАЛ РЕШЕНИЕ С МАССИВАМИ И Т.Д., ПЫТАЛСЯ РЕШИТЬ ЗАДАЧУ В РАМКАХ ТОГО ЧТО ПОКА ПРОХОДИЛИ

/*
void FindNum(int a)
{
    int b;
    
    while (a > 999)
    {
        a = a / 10;
    }  
    b = a%10; 
    if(a<=99)
        Console.WriteLine("a третьей цифры-то нет!");
    if((a>100)&&(a<1000))
        Console.WriteLine($"третья цифра {b}");
}

Console.WriteLine("input a");
int x = Convert.ToInt32(Console.ReadLine());

FindNum(x);

*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

*/
////////////////
/*
bool Checknum(int x)

{
    if((x==6)|(x==7))
    return true;
    return false;
}

Console.Write("input the digit");
int x = Convert.ToInt32(Console.ReadLine());
bool result = Checknum(x);

if(result)
    Console.WriteLine($" {x} выходной день недели");
else 
    Console.WriteLine($" {x} не выходной день недели");

*/

