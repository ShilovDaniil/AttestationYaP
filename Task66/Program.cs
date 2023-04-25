// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = Read("от числа m");
int n = Read("до числа n");

int Read(string arg)
{
  System.Console.WriteLine($"Введите промежуток {arg}:");
  return int.Parse(System.Console.ReadLine());
}

int NumSum(int m, int n)
{
  if(m<=n)
  {
    return m + NumSum(m+1,n);
  }
  return 0;
}

System.Console.WriteLine(NumSum(m,n));  