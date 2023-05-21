//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
void StepenNumber (string[] args)
{
    Console.WriteLine("Enter number A: ");
    double a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter number B: ");
    int b = Convert.ToInt32(Console.ReadLine());

    double result = 1;

    for (int i = 1; i <= b; i++)
    {
        result *= a;
    } 
    Console.WriteLine("Your number is: " + result);
}
StepenNumber(args);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*
void FindSum (string[] args)
{
    Console.WriteLine("Input your number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    int temp;

    while(number > 0)
    {
        temp = number % 10;
        sum += temp;
        number /= 10;
    }
    Console.WriteLine("Sum of your number is: " + sum);
}
FindSum(args);
*/

