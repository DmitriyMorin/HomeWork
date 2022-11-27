// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

int SumNumber(int number)
{
 int count = Convert.ToString(number).Length;
 int advance = 0;
 int result = 0;
 int i = 0;

    while (i < count)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
      i++;
    }
   return result;
}

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(numberN);
Console.WriteLine(sumNumber);