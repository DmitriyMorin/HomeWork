using static Library;
/* Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов*/

int [,] matrix = CreateArray(3, 4);
FillArrayRandomNumber(matrix);
PrintBad(matrix);
int sumLine = ElementsSum(matrix, 0);
int minSumLine = 0; 
for (int i = 1; i < matrix.GetLength(0); i++)
{  
  int tempSumLine = ElementsSum(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine();
Console.WriteLine($"({minSumLine+1}) - строкa с наименьшей суммой ");





