﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Type the number: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

if (number > number1 & number > number2)
{
    Console.Write("max = " + number);
}
else if (number1 > number & number1 > number2)
{
    Console.Write("max = " + number1);
}
else if (number2 > number & number2 > number1)
{
    Console.Write("max = " + number2);
}
else
{
    Console.Write("Some numbers are equal");
}


