public static class Library
{
  // печать массив
  public static string PrintGood(int[] numbers)
  {
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
      result += ($"{numbers[i],3} ");
      i++;
    }
    return result + "]";
  }

  // метод, который создаёт массив
  public static int[] CreateArray(int count)
  {
    return new int[count];
  }

  // заполняет массив
  public static void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max + 1);
      //array[i] = new Random().Next(min, max);
    }
  }

// нахождение всех положительных элементов массива
  public static int SumPositive(int[] numbers)
  {
    int result = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
      if (numbers[i] > 0) result += numbers[i];
    }
    return result;
  }

//нахолждение всех отрицательных элементов массива
  public static int SumNegative(int[] numbers)
  {
    int result = 0;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
      if (numbers[i] < 0) result += numbers[i];
    }
    return result;
  }

//возведения числа в натуральную степень
 public static int NaturalDegree(int numberA, int numberB)
{
  int result = 1;
  int i = 1;
while (i <= numberB)
 {
    result = result * numberA;
    i++;
 }
 return result;
}

//выдаёт сумму цифр в числе.

public static int SumNumber(int number)
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


}