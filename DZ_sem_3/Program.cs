/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Задача 21
*/

/*
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
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanceAB = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return distanceAB;
}
Console.WriteLine("Input x coordinat of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinat of A: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinat of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y coordinat of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinat of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z coordinat of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = CalculateDistance(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

Console.WriteLine($"Distance AB is {dist:f2}");
*/