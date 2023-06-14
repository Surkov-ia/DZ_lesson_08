// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно
//  выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк = ");
var rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
var colomns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество слоев = ");
var sloy = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[sloy, rows, colomns];

FillingArray();
PrintArray();
PrintIndexArrayLine();

void FillingArray()
{
    int numus = 9;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {
                array[i, j, s] = numus+1;
                numus++;
            }
            
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {
                Console.Write($"{array[i, j, s]} ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}

void PrintIndexArrayLine()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {
                Console.Write($"{array[i, j, s]}({i},{j},{s}) ");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}

