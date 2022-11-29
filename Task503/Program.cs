using static Library;
/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

Console.WriteLine("Введите количество эл массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumber(numbers);
Console.WriteLine("Вот наш массив: ");
PrintBad(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
Console.WriteLine($"Разность = {max - min}");