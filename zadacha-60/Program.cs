/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Write("Введите значение Х:  ");
int sizeOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y: ");
int sizeTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z: ");
int sizeThree = Convert.ToInt32(Console.ReadLine());

int[,,] arrayResult = new int[sizeOne, sizeTwo, sizeThree];
Random rnd = new Random();
    for (int i = 0; i < sizeOne; i++)
    {
        for (int j = 0; j < sizeTwo; j++)
        {
            for (int m = 0; m < sizeThree; m++)
            {
                arrayResult[i, j, m] = rnd.Next(10, 99);
            
            }
        } 
    }

void WriteArray (int[,,] array)
{
   for (int i = 0; i < sizeOne; i++)
    {
        for (int j = 0; j < sizeTwo; j++)
        {
            for (int m = 0; m < sizeThree; m++)
            {
                Console.Write($" {arrayResult[i, j, m]}({i}, {j}, {m}) "); 
            }
        } 
          Console.WriteLine();
    }
}
WriteArray(arrayResult);
