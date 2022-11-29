using static Library;
/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

Console.WriteLine("Введите количество эл массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumber(numbers);
Console.WriteLine("Вот наш массив: ");
PrintBad(numbers);
int result = SumOfPositionsOdd(numbers);
Console.WriteLine($"{result} сумма");