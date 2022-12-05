/* Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/


int n;
Console.Write("Введи значение от: ");
n = Convert.ToInt32(Console.ReadLine());
void foo(int i)
{
    if (n != i) foo(i + 1);
    System.Console.Write($"{i} ");
}
foo(1);