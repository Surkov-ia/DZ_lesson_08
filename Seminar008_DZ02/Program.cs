// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк = ");
var rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
var colomns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colomns];

FillingArray();
PrintArray();
Console.WriteLine("");
MinLineArray();
Console.WriteLine("");

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
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

int MinLineArray()
{
    int line = 0;
    int min = int.MaxValue;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
        if (result < min)
        {
            min = result;
            line = i;
        }
        Console.WriteLine($"Сумма чисел = {result} на строе {i}");
        result -= result;
    }
    Console.WriteLine("");
    Console.WriteLine($"Минимальное значение = {min}");
    Console.WriteLine("");
    Console.WriteLine($"Строка с минимальным значением = {line+1}");
    return result;
}
