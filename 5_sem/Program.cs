///////5 семинар/////////////////////////////
// Павел Гуляев: Задача 31: Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных элементов массива.

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

void ShowArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
    Console.WriteLine();
}


int FindNegSum(int[] arra)
{
    int sum = 0;
    for(int i = 0; i < arra.Length; i++)
        if(arra[i] < 0) sum += arra[i];
    return sum;
}

 Console.Write("input the sise of your array ");
 int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("input minimal value  ");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.Write("input maximum value  ");
 int max= Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(n, min, max);
ShowArray(newArray);

Console.WriteLine($"sum of negative elements is {FindNegSum(newArray)}");
*/


/*
2 задача
Павел Гуляев: Напишите программу для замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
*/




/*
3 задача
Павел Гуляев: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
*/

int [] CreateRandomArray(int n, int minVal, int maxVal)
{
    int [] arr = new int [n];
    for(int i=0; i < n; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal+1);
    } 
    return arr;
}

void ShowArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
    Console.WriteLine();
}


/*int FindNum(int[] arra)
{
    int sum = 0;
    for(int i = 0; i < arra.Length; i++)
        if(arra[i] < 0) sum += arra[i];
    return sum;
}
*/
bool FindNum(int [] array, int num)
    {
    int len = array.Length;
    for(int i = 0; i< len; i++)
    {
        if 
    }
    }

 Console.Write("input the sise of your array ");
 int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("input minimal value  ");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.Write("input maximum value  ");
 int seekNum= Convert.ToInt32(Console.ReadLine());

   Console.Write("Enter your number ");
 int max= Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateRandomArray(n, min, max);
ShowArray(newArray);

Console.WriteLine($"sum of negative elements is {FindNum(newArray)}");

if(FindNum(array, seekNum))
    Console.WriteLine("the number is found");
    else Console.WriteLine("the number is not found");

/*
4 задача
Павел Гуляев: Задайте одномерный массив из 15 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/


/*
5 задача
Павел Гуляев: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
*/

