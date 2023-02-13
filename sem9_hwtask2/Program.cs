// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значения M и N ");
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());

textTask();
if (M >= N)
Console.Write($"M => N, укажите корректные M и N");
else 
Console.Write($"M = {M}; N = {N} Сумма элементов = {SumNumbers(M, N)}\n");
Console.WriteLine("\n");

static int SumNumbers(int i, int n)
{   int sum = i;
    if (i < n) 
    {
        sum += SumNumbers(i + 1, n);
    }
    return sum;
}

void textTask()
{
    Console.WriteLine();  
}