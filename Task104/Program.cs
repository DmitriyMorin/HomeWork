// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numberEven = 2;

if(numberEven > 1)
{
    while(number >= numberEven)
    {
        Console.Write(numberEven + " ");
        numberEven = numberEven + 2;
    }
}
