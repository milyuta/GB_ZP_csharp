//////////////////
/*
///////////////Урок 4. Функции продолжение////////////////////////////////////
//////////Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
math.pow не сипользовать лучше организовать через цикл
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
int Involut(int a, int b)
    {
    int res = 1;
    for(int i = 1; i <= b; i++)
        {
            res=res*a;  
        }     
    return res;
    }
    
Console.WriteLine("input the number ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input the degree ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Involut(x, y));
*/

/*
////////////Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int SumDig(int num)
{
    int res =0;
    while(num>0)
    {
        res = res + num%10;
        num = num/10;
    }
    return res;
}
Console.WriteLine("input your number");
int x= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"total is  {SumDig(x)}");
*/

/*
////////////Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
основу мы проговаривали: сгенерировать массив и вывести. прописать метод, 
который будет генерировать массив не случайно, в цикле каждый элемент будет спрашивать
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*

int [] CreateArray()
{
    Console.WriteLine($"input the length of new array ");
    int j = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [j];
        for(int i=0; i < j; i++)
        {
            Console.WriteLine($"input {i+1} element of new array ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
}

void PrintArray(int [] arr)
{   
    Console.Write("[");
        for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");  
    Console.WriteLine("\b\b]");
}

PrintArray(CreateArray());

*/
