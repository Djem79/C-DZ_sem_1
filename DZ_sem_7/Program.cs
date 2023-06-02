/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double [,] Create2Array()
{
    Console.WriteLine("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maximal: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] created2Array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            created2Array[i,j] = Math.Round((new Random().Next(minVal, maxVal + 1)) + (new Random().NextDouble()), 2);
        }
    }
    return created2Array;
}

void Print2Array(double [,] array2d) 
{
    for(int i = 0; i < array2d.GetLength(0); i++) 
    {
        for (int j = 0; j < array2d.GetLength(0); j++) 
        {
            Console.Write(array2d[i,j] + " "); 
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();  
}

double[,] new2dArray = Create2Array();
Print2Array(new2dArray);
*/


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

/*
double[,] array = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.Write("Input number of row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column: ");
int col = Convert.ToInt32(Console.ReadLine());

double value = double.MinValue;
int numRows = array.GetLength(0);
int numCols = array.GetLength(1);

for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numCols; j++)
    {
        if (1 == row && j == col)
        {
            value = array[i, j];
            break;
        }
    }
}
if (value == double.MinValue)
{
    Console.WriteLine("Element in this position does not exist");
}
else
{
    Console.WriteLine("Value of element: " + value);
}
*/
