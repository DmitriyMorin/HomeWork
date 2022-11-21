// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if(NumberA > NumberB)
{
    max = NumberA;
    min = NumberB;
}
else
{
    max = NumberB;
    min = NumberA;
}
Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);