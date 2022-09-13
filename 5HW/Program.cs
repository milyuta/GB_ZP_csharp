////5hw
/*


Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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
void ShowArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
    Console.WriteLine();
}

int FindTwoDiv(int[] arra)
{
    int j = 0;
    for(int i = 0; i < arra.Length; i++)
        if(arra[i]%2 == 0) j ++;
    return j;
}


 Console.Write("input the sise of your array ");
 int n = Convert.ToInt32(Console.ReadLine());
  Console.Write("input minimal value  ");
 int min = Convert.ToInt32(Console.ReadLine());
  Console.Write("input maximum value  ");
 int max= Convert.ToInt32(Console.ReadLine());
int [] newArray = CreateRandomArray(n, min, max);
ShowArray(newArray);
Console.WriteLine($"Ammount of numbers that are divisible by 2 is {FindTwoDiv(newArray)}");

*/



/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
void ShowArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
    Console.WriteLine();
}
int FindSum(int[] arra)
{
    int i = 0;
    int sum = 0;
    for(i = 0; i < arra.Length; i=i+2)
        sum += arra[i];
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
Console.WriteLine($"sum of uneven elements is {FindSum(newArray)}");
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

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

void ShowArray(int [] arr)
{   
    Console.Write("[");
    for (int i = 0; i<arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b ]");
    Console.WriteLine();
}

int FindMinNums(int [] array) /// если это метод, который не возвращает - void

{
    int min = array[0];
    int max = array[0];
    int i =0;

    for(i = 0; i < array.Length; i++)
        if(min > array[i])  min =array[i];
    return min;



}
int FindMaxNums(int [] array) /// если это метод, который не возвращает - void

{
    int min = array[0];
    int max = array[0];
    int i =0;


    for(i = 0; i < array.Length; i++)
        if(max < array[i])  max =array[i];
    return max;

}


int min =0;
int max= 100;
int n = 10;

int [] newArray = CreateRandomArray(n, min, max);

ShowArray(newArray);

Console.WriteLine($"The difference of the biggest and the smallest numbers of the array is {FindMaxNums(newArray) - FindMinNums(newArray)}");

*/
