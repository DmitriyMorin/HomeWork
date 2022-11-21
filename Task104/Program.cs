// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Конвертирует (переводит) символы в цифры

int numberEven = 2;

if(numberEven > 1)
{
    while(number >= numberEven)
    {
        Console.Write(numberEven + " "); // Выводит все значения
        numberEven = numberEven + 2;
    }
}
