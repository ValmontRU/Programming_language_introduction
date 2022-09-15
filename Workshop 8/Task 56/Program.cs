// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindMinimumElementsSumRow(int[,] array)
{
    int rowSum = int.MaxValue;
    int minSumRowIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < rowSum)
        {
            rowSum = temp;
            minSumRowIndex = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов в {minSumRowIndex + 1}-й строке");
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
    Console.WriteLine();
    FindMinimumElementsSumRow(myArray);
}