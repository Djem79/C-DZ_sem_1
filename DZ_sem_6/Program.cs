//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
void MNumbers()
{
    Console.WriteLine("Input (M) numbers: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
            count++;
    }
    Console.WriteLine("Quantity numbers above 0 is: " + count);
}
MNumbers();
*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void FindIntersectionPoint()
{
    Console.WriteLine("First line equation (y = k1 * x +b1)");
    double[] firstLineParams = ReadLineParams();

    Console.WriteLine("Second line equation (y = k2 * x + b2)");
    double[] secondLineParams = ReadLineParams();

    double[] intersectionPoint = findIntersecPoint(firstLineParams, secondLineParams);
    
    Console.WriteLine("Intersection point:");
    Console.WriteLine("x = " + intersectionPoint[0]);
    Console.WriteLine("y = " + intersectionPoint[1]);

    double[] ReadLineParams()
    {
        double[] lineParams = new double[2];
        
        Console.Write("Enter k: ");
        lineParams[0] =  Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        lineParams[1] =  Convert.ToDouble(Console.ReadLine());

        return lineParams;
    }

    double[] findIntersecPoint(double[] firstLineParams, double[] secondLineParams)
    {
        double k1 = firstLineParams[0];
        double b1 = firstLineParams[1];

        double k2 = secondLineParams[0];
        double b2 = secondLineParams[1];

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        return new double[] {x, y};
    }
}
FindIntersectionPoint();
