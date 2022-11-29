using static Library;
/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве*/

Console.WriteLine("Введите количество эл массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumber(numbers);
Console.WriteLine("Вот наш массив: ");
PrintBad(numbers);
int result = CountIsEven(numbers);
Console.WriteLine($"{result} четных");

