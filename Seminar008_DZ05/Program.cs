// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк = ");
var rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
var colomns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colomns];

FillingArray();
PrintArray();

void FillingArray()
{
    int MaxRows = array.GetLength(0); 
    int MaxColomns = array.GetLength(1)-1;
    int min = 0;
    int r = 11;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = r;
        r++;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, MaxColomns] = r;
        r++;
    }
    for (int j = MaxColomns-1 ; j >= min; j--)
    {
        array[MaxRows-1, j] = r;
        r++;
    }
    for (int i = MaxRows-2 ; i >= min+1; i--)
    {
        array[i, min] = r;
        r++;
    }
    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        array[1, j] = r;
        r++;
    }
    for (int i = 2; i < array.GetLength(0)-1; i++)
    {
        array[i, MaxColomns-1] = r;
        r++;
    }
    for (int j = MaxColomns-2 ; j >= min+1; j--)
    {
        array[MaxRows-2, j] = r;
        r++;
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}




