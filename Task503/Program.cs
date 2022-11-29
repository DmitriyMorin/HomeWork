using static Library;
/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

Console.WriteLine("Введите количество эл массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumber(numbers);
Console.WriteLine("Вот наш массив: ");
PrintBad(numbers);
double result = (numbers);
Console.WriteLine($"{result} ");