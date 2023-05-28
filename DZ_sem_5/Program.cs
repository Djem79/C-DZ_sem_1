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

/*
int arrSize = 4;
int minValElm = 100;
int maxValElm = 999;

int [] randArr = CreateRandomArray (arrSize, minValElm, maxValElm);
ShowArray(randArr);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*
void summRandom (int [] arraySumNotEven)
{
    int sum = 0;
    for (int i = 0; i < arraySumNotEven.Length; i++)
        if (i % 2 != 0)
        {
            sum += arraySumNotEven[i];
        }
        Console.WriteLine ($"Summ of elenets is {sum}");
}

int arrSize = 6;
int minValElm = -99;
int maxValElm = 99;

int [] arrNew = CreateRandomArray (arrSize, minValElm, maxValElm);
ShowArray(arrNew);
summRandom(arrNew);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

