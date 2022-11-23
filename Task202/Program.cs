// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number); // Преобразует вводимое число в строку
if (numberText.Length > 2)
{
  Console.WriteLine(numberText[2]);
}
else 
{
  Console.WriteLine(" Третьей цифры нет ");
}