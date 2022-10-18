// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());



int SumRec(int M, int N)
{
    if (M < N) return M + SumRec(M + 1, N);
    return N;
}

int sum = SumRec(M, N);
Console.WriteLine(sum);
