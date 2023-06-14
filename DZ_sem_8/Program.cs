//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2



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