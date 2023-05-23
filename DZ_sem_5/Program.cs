/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] CreateRandomArray (int size, int minVal, int maxVal)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + i);
    return newArray;
    
}

void ShowArray(int [] array1)
{
    for(int i = 0; i < array1.Length; i++)
        Console.Write(array1 [i] + " ");
    Console.WriteLine();
}

int arrSize = 4;
int minValElm = 100;
int maxValElm = 999;

int [] randArr = CreateRandomArray (arrSize, minValElm, maxValElm);
ShowArray(randArr);


