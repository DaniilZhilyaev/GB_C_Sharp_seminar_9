/*Задача 1:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"

N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{NatNumbers(number, 1)}");

string NatNumbers(int numbers, int i)
{
    if (numbers == i) return i.ToString();
    return (((i)  + ", " + NatNumbers(numbers, i +1)));
}