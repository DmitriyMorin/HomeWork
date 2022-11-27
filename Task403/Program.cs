using static Library;
// Напишите методы, который задаёт массив из 8 элементов и выводит их на экран.


int countElements = GetNumber("Введите количество эл массива: ");
int[] arr = CreateArray(countElements);
Fill(arr);
PrintGood(arr);
Console.WriteLine(PrintGood(arr));