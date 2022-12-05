/* Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/

int n, m, s=0;
Console.Write("Введи значение от: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи значение до: ");
m = Convert.ToInt32(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine(s);