public static class Library
{
  public static int[,] CreateArray(int n, int m)
  {
    return new int[n, m];
  }
 public static void FillArrayRandomNumber(int[,] numbers)
 {
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        {
            for(int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = new Random().Next(0,20);
            }
        }      
    }
 }
 public static void PrintBad(int[,] numbers)
{
    
    for(int i = 0; i < numbers.GetLength(0); i++)
     {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j], 4}");
            
        }
     Console.WriteLine();
     }

}
 public static void OrderArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

}