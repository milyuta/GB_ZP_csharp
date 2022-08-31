//////////////////////////////////////////////////
//Урок 3. Массивы и функции в программировании
/*
///////////////////Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

/*
void CheckPaliand(string? number)

{
    if (number!.Length != 5)
    {
       Console.WriteLine("input 5-digit number");
    }
        else 
        if (number[0]==number[4]&&number[1]==number[3])
        {
            Console.WriteLine($"your number  {number} is palindrome");
        }
            else Console.WriteLine($"your number  {number} is not palindrome");
}

Console.WriteLine("input your number");
string? num = Console.ReadLine();
CheckPaliand(num);
*/

/*

///////////////////Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{   
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;
    double length=Math.Pow(dx*dx + dy*dy+ dz*dz, 0.5);
    return length;
    ///Console.Write(length);
}

Console.WriteLine("Input x-coordinates of the 1 point");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y-coordinates of the 1 point");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z-coordinates of the 1 point");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x-coordinates of the 2 point");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y-coordinates of the 2 point");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z-coordinates of the 2 point");
double z2 = Convert.ToInt32(Console.ReadLine());
//
Console.WriteLine($"THe length of the line is {Length(x1, y1, z1, x2, y2, z2)}" );

*/



/*
///////////////////Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/
/*
void Raise3(int a)
    {
        int i =1;
        int q = 1;
        while(i <= a)
        {
            q = i*i*i;
            i++;
            Console.WriteLine(q);
         }
    }

Console.WriteLine("input the number: ");
int thirdDeg=Convert.ToInt32(Console.ReadLine());
Raise3(thirdDeg);
*/
