
Console.Write("Введите количество строк = ");
var rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов = ");
var colomns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colomns];

FillingArray();
PrintArray();
RegulateArray();
Console.WriteLine("");
PrintArray();

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

void RegulateArray()
{
    int MaxArray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(1) - 1; s++)
            {
                if (array[i, s] < array[i, s + 1])
                {
                    MaxArray = array[i, s + 1];
                    array[i, s + 1] = array[i, s];
                    array[i, s] = MaxArray;
                }
            }
        }
    }
}
