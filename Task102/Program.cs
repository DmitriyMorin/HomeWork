// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max = 0;

Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine()); // Конвертирует (переводит) символы в цифры

Console.Write("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int NumberC = Convert.ToInt32(Console.ReadLine());

if(NumberA > max) max = NumberA;
if(NumberB > max) max = NumberB;
if(NumberC > max) max = NumberC;

Console.Write("Max = ");
Console.WriteLine(max);
