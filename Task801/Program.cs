using static Library;
/* Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

int [,] matrix = CreateArray(3, 4);
FillArrayRandomNumber(matrix);
PrintBad(matrix);
Console.WriteLine("Отсортированный массив: ");
OrderArray(matrix);
PrintBad(matrix);



