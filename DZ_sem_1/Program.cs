/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Input your first number:");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number:");
int number_b = Convert.ToInt32(Console.ReadLine());

if(number_a > number_b)
{   
    //Console.WriteLine("Число а  больше числа b ");   //Можно показать и какое из чисел больше
    Console.WriteLine("Наибольшее число: " + number_a);
}
else if(number_a < number_b)
{
   //Console.WriteLine("Число b больше числа a"); 
    Console.WriteLine("Наибольшее число: " + number_b);
}
else
{
    Console.WriteLine("Числа равны");
}
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1; 

if (number2 > maxNumber)
{
    maxNumber = number2; 
}

if (number3 > maxNumber)
{
    maxNumber = number3; 
}

Console.WriteLine("Максимальное число: " + maxNumber);
Console.ReadLine();
*/

