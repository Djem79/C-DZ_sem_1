/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21
*/


void Palindrom()
{
    Console.WriteLine("Input your number");
    int number = Convert.ToInt32(Console.ReadLine());
    int firstDigit = number / 10000;
    int secondDigit = number % 10000 / 1000;
    int thirdDigit = number % 1000 / 10;
    int fourthDigit = number % 100 / 10;
    int fithDigit = number % 10;

    if (firstDigit == fithDigit && secondDigit == fourthDigit)
        Console.WriteLine("This is palindrom. ");
    else
        Console.WriteLine("This is not palindrom!");
}
Palindrom();
