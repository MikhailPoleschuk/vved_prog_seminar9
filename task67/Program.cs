//67
Console.Clear();
Console.WriteLine("Введите число:");

string str = Console.ReadLine();
int sum = 0;
int NoNumber =0;
for (int i = 0; i < str.Length; i++)
{
    if (Convert.ToInt32(str[i]) > 47 & Convert.ToInt32(str[i]) < 59)
        sum += Convert.ToInt32(str[i]) - 48;


    else { Console.WriteLine("Вы ввели не число"); NoNumber = 1; break; }
}

if (NoNumber==0) Console.WriteLine(sum);






