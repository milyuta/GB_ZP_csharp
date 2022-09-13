/*
////////////////////////////// 7 hw
Урок 7. Как не нужно писать код. Часть 1
Скрыть
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

*/

/*
double [,] CreateRandom2dArray()
{
    Console.Write("input nembers of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input nembers of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min value");
    int minVal = Convert.ToInt32(Console.ReadLine())*10;
    Console.Write("input max value");
   int maxVal = Convert.ToInt32(Console.ReadLine())*10;

    double[,] newArray = new double [rows, columns];

    for(int i=0; i < rows; i++) 
    {   
        for(int j = 0; j< columns; j++)
        { 
            newArray[i, j]=Convert.ToDouble(new Random().Next(minVal, maxVal +1))/10;
        }   
    }    

    return newArray;
} 

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }

    Console.WriteLine();
}


Show2dArray(CreateRandom2dArray());
*/

/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет


*/

/*
int[,] CreateRandom2dArray()
{    
    Console.Write("input nembers of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input nembers of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min value");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max value");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for(int i=0; i < rows; i++) 
    {   
        for(int j = 0; j< columns; j++)
        { 
            newArray[i, j]=new Random().Next(minVal, maxVal +1);
        }   
    }    

    return newArray;
} 


void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }

    Console.WriteLine();
}


void FindSame(int[,]array)
{
Console.WriteLine("input row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input column number: ");
int column = Convert.ToInt32(Console.ReadLine());
    
    if(row>array.GetLength(0) || column>array.GetLength(1))
    Console.WriteLine($"There is no number which has ({row},{column}) position");
    else Console.WriteLine($"{array[row-1, column-1]}  position is ({row},{column})");
}  

int [,] newArray = CreateRandom2dArray();

Show2dArray(newArray);
FindSame(newArray);


*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/
/*

int[,] CreateRandom2dArray()
{    
    Console.Write("input nembers of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input nembers of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min value");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max value");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for(int i=0; i < rows; i++) 
    {   
        for(int j = 0; j< columns; j++)
        { 
            newArray[i, j]=new Random().Next(minVal, maxVal +1);
        }   
    }    

    return newArray;
} 


void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }

    Console.WriteLine();
}


double AverageOfColumns(int[,]array)
{
    double average = 0;
    int n=0;
    for(int i=0; i < array.GetLength(1); i++) 
    {   
        double sum = 0; 
       
        for(int j = 0; j<array.GetLength(0); j++)
        { 
            sum += array[j,i];
        } 
        n++;
        average = sum/(array.GetLength(0));
        Console.WriteLine($"average of the {n} column is {average:f1}");
       
    }  
    return average;
}  

int [,] newArray = CreateRandom2dArray();

Show2dArray(newArray);
AverageOfColumns(newArray);
*/