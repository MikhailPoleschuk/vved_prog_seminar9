/ string NumbersFor(int a, int b)
// {
//  string result = String.Empty;
//  for (int i = a; i <= b; i++)
//  {
//  result += $"{i} ";
//  }
//  return result;
// }

string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty;
}
// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


// int n=1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//  if (length == word.Length)
//  {
//  Console.WriteLine($"{n++} {new String(word)}"); return;
//  }
//  for (int i = 0; i < alphabet.Length; i++)
//  {
//  word[length] = alphabet[i];
//  FindWords(alphabet, word, length + 1);
//  }
// }
// FindWords("мпа", new char[5]);




// char[] s = { 'а', 'и', 'с','в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//  for (int j = 0; j < count; j++)
//  {
//  Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
//  }
// }
