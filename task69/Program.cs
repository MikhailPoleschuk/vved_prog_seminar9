// 69
Console.Clear();
Console.WriteLine("Введите A:");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());



int SumRec(int a, int b)
{
    if (b > 1) return a * SumRec(a, b-1);
    return a;
}

int sum = SumRec(a, b);
Console.WriteLine(sum);
