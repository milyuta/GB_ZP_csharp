/// 1 пример
///Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.
//тип данных которые нужно получить int, FindBiggerDigit - название мметода 

/*
int FindBiggerDigit(int number) /// если это метод, который не возвращает - void

{
    int ed = number % 10;
    int dec = number / 10;
    
    int result;

    if(ed > dec) result = ed;
    else result = dec;

    return result;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);
Console.WriteLine($"Bigger digit of {randNumber} IS {biggerDigit}");

*/

/* также возможен слудующий вариант без result:

{
    int ed = number % 10;
    int dec = number / 10;
   
    if(ed>dec) return ed;
    else return dec;
}
*/
/*
2 задача
Павел Гуляев: Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.

будет входящее трехзначное и исходящее двузначное
остаток от деления
обйтись без конвертации типов данных
*/
/* 2 задача решение

int Pack(int Num)

{
    int high, low, res;
    high = Num/100;
    low = Num % 10; 
    res = high*10 + low;
    return res;
}

int randNumber = new Random().Next(100, 999);
int res = Pack(randNumber);

Console.WriteLine($"{res} is 2-digit number of {randNumber} ");
*/


/*
3 задача Павел Гуляев: Напишите программу, которая будет принимать на вход два 
числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, 
то программа выводит остаток от деления.

реализовать через void 
вывести через writeline внутри метода
*/
/*3 задача


void DivineNum(int a, int b)
{
    int res = b%a;
    if(b%a==0)
    Console.WriteLine("b кратно a");
    else Console.WriteLine($"b/a остаток {res}");
}

Console.WriteLine("input a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b");
int b = Convert.ToInt32(Console.ReadLine());

DivineNum(a, b);
*/

/* Задача 4
Павел Гуляев: Напишите программу, которая принимает 
на вход число и проверяет, кратно ли оно одновременно 7 и 23.
решить в общем виде где число будет кратно А и Б в методе

*/
bool CheckDig(int x, int a, int b);
int a = 2;
int b =3;

{
    if((x % a==0)&(x % b==0))
    return true;
    //else return false;
    return false;
}

Console.Write("input the digit");
int x = Convert.ToInt32(Console.ReadLine());
CheckDig(x, a, b);