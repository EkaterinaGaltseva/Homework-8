/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */ 

Console.Write("Введите количество столбцов желаемого массива:   ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк желаемого массива:  ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первая матрица: ");
int[,] matrixOne = new int[lines, column];
Random rnd = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
          matrixOne[i, j] = rnd.Next(0, 10);
          Console.Write($" {matrixOne[i, j]} ");    
        } 
          Console.WriteLine();
    }

Console.WriteLine("Вторая матрица: ");
int[,] matrixTwo = new int[lines, column];
Random random = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
          matrixTwo[i, j] = rnd.Next(0, 10);
          Console.Write($" {matrixTwo[i, j]} ");    
        } 
          Console.WriteLine();
    }


int[,] resultMatrix = new int[lines, column];


Console.WriteLine("Результирующая матрица будет:");

void MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int summ = 0;
      for (int k = 0; k < matrixOne.GetLength(1); k++)
      {
        summ += matrixOne[i,k] * matrixTwo[k,j];
      }
      resultMatrix[i,j] = summ;
    }
  }
}
MultiplyMatrix(matrixOne, matrixTwo, resultMatrix);
WriteArray(resultMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}