// 63

Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int a, int N)
{

    string str = String.Empty;
    if (a <= N) return str = $"{a}   {NumbersRec(a + 1,N)}";
    else return String.Empty;
}
int a = 1;
Console.WriteLine(NumbersRec(a,N));