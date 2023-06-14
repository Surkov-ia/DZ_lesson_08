// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк = ");
var rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
var colomns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество слоев = ");
// var sloy = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows, colomns];
int[,] array2 = new int[rows, colomns];
int[,] result = new int[rows, colomns];

FillingArray(array1);
PrintArray(array1);
Console.WriteLine();
FillingArray(array2);
PrintArray(array2);
Console.WriteLine();
SumArray(result);
PrintArray(result);

void FillingArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void SumArray(int[,] result)
{

    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Количество строк и сторон разное!!!");
        return;
    }
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int s = 0; s < array1.GetLength(1); s++)
            {
                result[i, j] += array1[i, s] * array2[s, j];
            }
        }
    }
}