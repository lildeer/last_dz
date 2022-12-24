// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Acc(m, n));

int Acc (int m, int n)
{
    while (m!= 0)
    {
        if (n ==0) n  = 1;
        else n = Acc(m, n-1);
        m = m-1;
    }
    return n+1;
}