// 65

Console.Clear();
Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());



string NumbersRec(int M, int N)
{

    
    if (M <= N) return $"{M}   {NumbersRec(M + 1,N)}";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(M,N));