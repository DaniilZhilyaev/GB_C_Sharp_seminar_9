/**Задача 3:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)

A = 2; B = 3 -> 8 */

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} в степени {b} равно - {SqrNumbers(a, b)}");

int SqrNumbers(int number, int numbersqr)
{    
        if (numbersqr == 0) return 1;
        return (number * SqrNumbers(number, numbersqr - 1));
    }

