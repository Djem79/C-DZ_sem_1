//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


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
