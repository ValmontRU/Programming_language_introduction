// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MeanInEachColumn(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] += array[i, j];
        }
    }
    Console.WriteLine();
    foreach (double element in sum)
    {
        double result = element / array.GetLength(0);
        Console.Write($"{result:f2}\t");
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

if (rows < 2 || columns < 2) Console.Write("Вы ввели недостаточное количество строк/столбцов для построения двумерного массива");
else
{
    int[,] myArray = GetArray(rows, columns);
    PrintArray(myArray);
    MeanInEachColumn(myArray);
}