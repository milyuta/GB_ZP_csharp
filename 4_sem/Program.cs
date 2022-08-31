/////////////////////////////
//4 seminar


//task 1
// Павел Гуляев: Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.


/*
int FindSum(int a)
{
    int sum = 0; //вводим эту переменную, когда знаем что 
    //что-то конкретное нужно представить в виде результата
    // также это называется выделение памяти в процессе обработки метода

    for (int current = 1; current <= a; current ++)
    {
        sum += current;
    }
    return sum;
}

Console.WriteLine("input the number ");
int num = Convert.ToInt32(Console.ReadLine());// тут кстати можно тоже 
//переменную "а" делать

Console.WriteLine($"sum of numbers from 1 to {num} is {FindSum(num)}");

/// также возможна следующая запись

//int result=FindSum(num);
//Console.WriteLine($"sum of numbers from 1 to {num} is {result}");
*/


/*
Павел Гуляев: Напишите программу, которая принимает на вход 
число и выдаёт количество цифр в числе.
*/


/*
int CountDigits(int num)
{
    int result = 0;
    while (num >0)
    {
        result++;
        num/=10;
    }
    return result;
}

Console.WriteLine("input the number ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Count of digits in {n} is {CountDigits(n)}");
*/



/*
Павел Гуляев: Напишите программу, которая принимает на вход
 число N и выдаёт произведение чисел от 1 до N.
*/


/*
int Factorial(int num)
    {
       int multi = 1;
       for(int i =1; i<= num; i++)
       multi*=i;
       return multi;
    }

Console.WriteLine("input the number ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n}! is {Factorial(n)}");
*/



/*
Павел Гуляев: Напишите программу, которая выводит массив 
из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/

/*
int [] CreateRandomArray(int n, int minVal, int maxVal)
{
    int [] arr = new int [n];
    for(int i=0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal+1);
    } 
    return arr;
}

void PrintArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
}

PrintArray(CreateRandomArray(8, 0, 1));
*/

///////// почти то же самое ///////////


/*
int [] CreateRandomArray(int n, int minVal, int maxVal)
{
    int [] arr = new int [n];
    for(int i=0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal+1);
    } 
    return arr;
}

void PrintArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
}

int [] newArr = CreateRandomArray(8, 0, 1);
PrintArray(newArr);
*/

