﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{NatNumbers(number)}");

string NatNumbers(int numbers)
{
    if (numbers == 1) return numbers.ToString();
    return (((numbers)  + ", " + NatNumbers(numbers - 1)));
}