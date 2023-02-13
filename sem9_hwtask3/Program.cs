//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите значения M и N ");
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());

Text();
Console.Write($"n = {N}; m = {M} -> A(n, m) = {Ackerman(M, N)}\n");
Console.WriteLine("\n");

static int Ackerman(int N, int M)
{
    if (N == 0)
        return M + 1;
    if (N != 0 && M == 0)
        return Ackerman(N - 1, 1);
    if (N > 0 && M > 0)
        return Ackerman(N - 1, Ackerman(N, M - 1));
    return Ackerman(N, M);
}

void Text()
{
    Console.WriteLine();
}

