
//////////////////////////////////////
/////////////////homework 1

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("input first integer number: ");
int number1  = Convert.ToInt32(Console.ReadLine());
Console.Write("input second integer number: ");
int number2  = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine($"{number1} is bigger than {number2}");
}
else
{
    Console.WriteLine($"{number2} is bigger than {number1}");
}
*/


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("input first integer number: ");
int number1  = Convert.ToInt32(Console.ReadLine());
Console.Write("input second integer number: ");
int number2  = Convert.ToInt32(Console.ReadLine());
Console.Write("input third integer number: ");
int number3  = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(max > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if(max > number3)
{
    max = max;
}
else
{
    max = number3;
}
Console.WriteLine($"{max} is the biggest number");
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/


/*
Console.Write("input the number ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 ==0)
{
    Console.WriteLine($"{num} is divisible by 2");
}
else
{
    Console.WriteLine($"{num} is not divisible by 2");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("input the number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
while(current <= num)
{
    Console.WriteLine(current);
    current += 2;
}
*/