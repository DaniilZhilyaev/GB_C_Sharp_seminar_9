/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Результат: {AkkFunction(m, n)}");

int AkkFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkFunction(m - 1, 1);
    return AkkFunction(m - 1, AkkFunction(m, n - 1));
}