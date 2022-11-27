public static class Library
{
  // Метод печати массива
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

  // метод, который заполняет массив случайными цифрами
  public static void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = Random.Shared.Next(min, max + 1);
      //array[i] = new Random().Next(min, max);
    }
  }

// метод, нахождения всех положительных элементов массива
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

// метод нахолждения всех отрицательных элементов массива
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

// метод возведения числа в натуральную степень
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

// метод, который выдаёт сумму цифр в числе.
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

// Метод, считывающий число от пользователя из консоли
public static int GetNumber(string text)
{
  Console.Write(text);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

// метод, заполняющий массив поэлементно *от пользователя
public static void Fill(int[] array)
{
  int size = array.Length;

  int index = 0;
  while (index < size)
  {
    array[index] = GetNumber($"array[{index}]: ");
    index++;
  }
}

// метод, подсчёта четных элементов массива
public static int CountIsEven(int[] elements)
{
  int result = 0;

  int size = elements.Length;
  int i = 0;
  while (i < size)
  {
    if (elements[i] % 2 == 0) result++;
    i++;
  }

  return result;
}

// метод, формирующий новый массив на основе имеющегося
public static int[] Solution(int[] collectionElements, int evenCounts)
{
  int[] items = new int[evenCounts];
  int length = collectionElements.Length;
  int position = 0;
  int indexInItems = 0;
  while (position < length)
  {
    if (collectionElements[position] % 2 == 0)
    {
      items[indexInItems] = collectionElements[position];
      indexInItems++;
    }
    position++;
  }

  return items;
}

// метод удаления пробелов из строки 
public static string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

// метод проверки на правильность ввода 
public static void СheckNumber2 (int  series)
 {

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {

      }
        else 
      {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
 }

// метод замены элементов массива на противоположный
public static int[] Inverse(int[] input)
  {
    int size = input.Length;
    int[] output = new int[size];
    for (int i = 0; i < size; i++)
    {
      output[i] = -input[i];
    }
    return output;
  }
/*public static void Inverse(int[] input)
  {
    int size = input.Length;
    for (int i = 0; i < size; i++)
    {
      input[i] = -input[i];
    }
  }*/

// метод поиска заданного числа в массиве
public static bool FindElement1(int[] col, int find)
  {
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
      if (col[i] == find) return true;
    }
    return false;
  }
 /*public static bool FindElement2(int[] col, int find)
  {
        return Array.IndexOf(col, find) != -1;
  }*/

}