// 3 семинар 
//1 задача

/*Павел Гуляев: Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/

// double тип какой?
/*
int FindQuadr(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
// && логическое "и" то есть оба условия одновременно
// 
Console.Write("input x coordinate:");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y coordinate:");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadr(xA, yA);
Console.WriteLine("Number of quadrant is" + quadrant);
*/


/*
2 задача Павел Гуляев: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой 
четверти (x и y). void
*/


/*
void FindDiapasone(int quad)
{
    string output = "некорректный ввод данных";
    if (quad == 1)
    output = $"Для четверти {quad} x > 0, y > 0";
    if (quad == 2)
    output = $"Для четверти {quad} x < 0, y > 0";
    if (quad == 3)
    output = $"Для четверти {quad} x < 0, y < 0";
    if (quad == 4) 
    output = $"Для четверти {quad} x > 0, y < 0";
    Console.WriteLine(output);
}

Console.Write("Input number of quadrant");
int numQuad = Convert.ToInt32(Console.ReadLine());

//string result = FindDiapasone(numQuad);
//Console.WriteLine("The diapasone is " + result);
FindDiapasone(numQuad);
*/


/*
3 задача Павел Гуляев: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N. void
*/

/*
void Quad(int a)
    {
        int i =1;
        int q = 1;
        while(i <= a)
        {
            q = i*i;
            i++;
            Console.WriteLine(q);
        }
    }

Console.WriteLine("input the number: ");
int quadro=Convert.ToInt32(Console.ReadLine());
Quad(quadro);
*/


/*
4 задача Павел Гуляев: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 2D пространстве.
4 аргумента: по 2 на каждую точку
*/

double Length(double x1, double y1, double x2, double y2)
{   
    double dx = x2 - x1;
    double dy = y2 - y1;
    double length=Math.Pow(dx*dx + dy*dy, 0,5);
    return length;
    Console.WriteLine(length);
}

Console.ReadLine("Input x-coordinates of the 1 point");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.ReadLine("Input y-coordinates of the 1 point");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.ReadLine("Input x-coordinates of the 2 point");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.ReadLine("Input y-coordinates of the 2 point");
double y2 = Convert.ToInt32(Console.ReadLine());

double len=Length(len);
