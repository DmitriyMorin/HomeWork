/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

int n, m;
Console.Write("Введи число n: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число m: ");
m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(A(n, m));

int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}




