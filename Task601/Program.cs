using static Library;

/*Задача: доделать задачу сложения\вычитания двух многочленов.
Реализовать красивый вывод.
Подумать над перемножением*/


int[] f = { 1, 0, 2, 0, 0, -6, 5 };
int[] g = { 1, 1, -2, -5, 0, 0, 7, 3 };
Console.WriteLine(Print(f));
Console.WriteLine();
Console.WriteLine(Print(g));
Console.WriteLine();
int[] s = Sum(f, g);
Console.WriteLine(Print(s));
int[] d = Diff(f, g);
Console.WriteLine(Print(d));
Console.WriteLine();