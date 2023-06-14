/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void NaturalNumbers()
{
    Console.Write("Input N number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    PrintNaturalNumbers(n);

    void PrintNaturalNumbers(int n)
    {
        if(n >= 1)
        {
            Console.WriteLine(n);
            PrintNaturalNumbers(n - 1);
        }
    }
}
NaturalNumbers();
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
void FindSum()
{
    Console.Write("Input M value: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input N value: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int sum = GetSumOfNaturalNumbers(m, n);
    Console.WriteLine("The sum of natural number from {0} to {1} equals: {2}", m, n, sum);

    int GetSumOfNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        else
        {
            return m + GetSumOfNaturalNumbers(m + 1, n);
        }
    }
}
FindSum();
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int AckermannFunction(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    } else if (m > 0 && n == 0) 
    {
        return AckermannFunction(m - 1, 1);
    } 
    else 
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}


Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine("Result for Ackerman function is m={0} и n={1}: {2}", m, n, result);
