// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(m-1,A(m,n-1))

Console.Clear();
Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());



int AccRec(int m, int n)
{
    if (m >= 0)
    {
        m--;
        return AccRec(m, AccRec(m, n - 1));  // не верное значение, что то явно не то вычисляю
        
        // Stack overflow: return AccRec(m, AccRec(m+1, n - 1));
        // Stack overflow: return AccRec(m-1, AccRec(m, n - 1));
    }
    return n + 1;
}


Console.WriteLine(AccRec(m, n));

