//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.



Console.Write("Введите трезначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int B = (number / 10) % 10;

Console.WriteLine(B);
