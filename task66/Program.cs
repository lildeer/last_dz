// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n) System.Console.WriteLine(Rec(m, n));
else System.Console.WriteLine(Rec(n, m));

int Rec(int m, int n)
{
    if (m == n) return m;
    return (m + Rec(m - 1, n));
}