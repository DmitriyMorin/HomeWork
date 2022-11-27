// метод, который создаёт массив
int[] CreateArray(int count)
{
  return new int[count];
}

// заполняет массив
void Fill(int[] array, int min, int max)
{
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    //array[i] = Random.Shared.Next(min, max + 1);
    array[i] = new Random().Next(min, max);
  }
}

// печать массив
string PrintGood(int[] numbers)
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

// нахождение всех положительных элементов массива
int SumPositive(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] > 0) result += numbers[i];
  }
  return result;
}

// нахолждение всех отрицательных элементов массива
int SumNegative(int[] numbers)
{
  int result = 0;
  int size = numbers.Length;
  for (int i = 0; i < size; i++)
  {
    if (numbers[i] < 0) result += numbers[i];
  }
  return result;
}

// 
int[] col = CreateArray(12);
Console.WriteLine(PrintGood(col));
Fill(col, -9, 9);
Console.WriteLine(PrintGood(col));
int pos = SumPositive(col);
Console.WriteLine($">0 {pos}");
int neg = SumNegative(col);
Console.WriteLine($"<0 {neg}");

