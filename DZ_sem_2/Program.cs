/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*void SecDig()
{
    Console.WriteLine("Input your 3 digit number ");
    int user_number = Convert.ToInt32(Console.ReadLine());

    if (user_number > 100 && user_number < 1000)
    {
        int second_digit = (user_number / 10) % 10;
        Console.WriteLine("Second digit is: " + second_digit);
    }
    else
    {
        Console.WriteLine("You enter wrong number.");
    }
}
SecDig();*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


void thirdDigit()
{
    Console.WriteLine("Input your number:");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99)
    {   
        Console.WriteLine("Third digit is: " + num % 10);
    }
    else
    {
        Console.WriteLine ("Your number have no third digit");
    }
}
thirdDigit();

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = (int)(number / Math.Pow(10, 2)) % 10;

        if (thirdDigit == 0)
        {
            Console.WriteLine("В вашем числе нет третьей цифры.");
        }
        else
        {
            Console.WriteLine("Третья цифра вашего числа: " + thirdDigit);
        }

        Console.ReadKey();
    }
}\
*/

