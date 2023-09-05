//Напишите программу, которая будет принимать на вход
//число и возвращать сумму его цифр.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {number} равна {SumNumbers(number)}");

int SumNumbers(int numbers)
{
    if (numbers ==0) return 0;
    return (numbers % 10 + SumNumbers(numbers / 10));
}