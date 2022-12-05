public static class Library
{
  public static int[,,] CreateArray(int i, int j, int k)
  {
    return new int[i, j, k];
  }
 public static void FillArrayRandomNumber(int[,,] numbers)
 {
    for(int i = 0; i < numbers.GetLength(0); i++)
    {        
       for(int j = 0; j < numbers.GetLength(1); j++)
        {
          for(int k = 0; k < numbers.GetLength(2); k++)
            {
              numbers[i, j, k] = new Random().Next(10,100);
              Console.WriteLine($"{numbers[i, j, k]}({i},{j},{k})");
            }
        }        
    }
 }
 public static void PrintBad(int[,,] numbers)
 {
    for(int i = 0; i < numbers.GetLength(0); i++)
     {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
          for (int k = 0; k < numbers.GetLength(2); k++)
          {
            Console.Write($"{numbers[i, j, k], 4}");
          }
        }
      Console.WriteLine();
      } 
 }


 
 




}