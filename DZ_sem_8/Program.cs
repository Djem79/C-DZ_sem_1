//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


/*
int[,] array = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

int numRows = array.GetLength(0);
int numCols = array.GetLength(1);

for (int row = 0; row < numRows; row++)
{
    for (int i = 0; i < numCols; i++)
    {
        for (int j = 0; j < numCols -  i - 1; j++)
        {
            if (array[row, j] < array[row, j + 1])
            {
                int temp = array[row, j];
                array[row,j] = array[row, j + 1];
                array[row, j + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Sorted array: ");

for (int row = 0; row < numRows; row++)
{
    for(int col = 0; col < numCols; col++)
    {
        Console.Write(array[row, col] + " ");
    }
    Console.WriteLine();
}
*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int[,] array = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

int numRows = array.GetLength(0);
int numCols = array.GetLength(1);

int minSumRow = 0;
int minSum = int.MaxValue;

for (int row = 0; row < numRows; row++)
{
    int sum = 0;

    for(int col = 0; col < numCols; col++)
    {
        sum += array[row, col];
    }
    if(sum < minSum)
    {
        minSum = sum;
        minSumRow = row;
    }
}

Console.WriteLine("Minimum sum element row: " + (minSumRow + 1));
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] matrix1 = {
{ 2, 4 },
{ 3, 2 }
};

int[,] matrix2 = {
{ 3, 4 },
{ 3, 3 }
};

int numRows1 = matrix1.GetLength(0);
int numCols1 = matrix1.GetLength(1);

int numRows2 = matrix2.GetLength(0);
int numCols2 = matrix2.GetLength(1);

if(numCols1 != numRows2)
{
    Console.WriteLine ("Imposible!!");
    return;
}

int [,] product = new int[numRows1, numCols2];

for (int row = 0; row < numRows1; row++)
{
    for( int col = 0; col < numCols2; col++)
    {
        int sum = 0;
        for( int k = 0; k < numCols1; k++)
        {
            sum += matrix1[row, k] * matrix2[k, col];
        }
        product[row, col] = sum;
    }
}

Console.WriteLine("Sum of matrix: ");

for(int row = 0; row < numRows1; row++)
{
    for(int col = 0; col < numCols2; col++)
    {
        Console.Write(product[row, col] + " ");
    }
    Console.WriteLine();
}
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int[,,] array = new int[2, 2, 2];
int minNum = 10;
int maxNum = 99;
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int num;
            bool isUnique;
            do
            {
                num = random.Next(minNum, maxNum + 1);
                isUnique = IsUnique(array, num);
            }
            while (!isUnique);
            array[i, j, k] = num;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
        }
    }
}

bool IsUnique (int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k] == num)
                {
                    return false;
                }
            }
        }
    }
    return true;
}
