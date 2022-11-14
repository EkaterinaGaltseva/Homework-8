/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Write("Введите количество столбцов желаемого массива:   ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк желаемого массива:  ");
int lines = Convert.ToInt32(Console.ReadLine());
if (lines <= column)
{
    Console.Write("Массив должен быть прямоугольным.Количество строк должно быть больше столбцов");

}
else
{
int[,] array = new int[lines, column];
Random rnd = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < column; j++)
        {
          array[i, j] = rnd.Next(0, 10);
          Console.Write($" {array[i, j]} ");    
        } 
          Console.WriteLine();
    }
int summ = 0;
int index = 0;
for (int i = 0; i < lines; i++)
    {
        int temp = 0;
        for (int j = 0; j < column; j++)
        {
          temp =+ array[i, j];  
          if (temp > summ)
          {
            summ = temp;
            index = i;
          }

        } 
    
    }
    Console.WriteLine($"Строка: {index + 1}");
}