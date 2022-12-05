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
 
 public static int ElementsSum(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}




}