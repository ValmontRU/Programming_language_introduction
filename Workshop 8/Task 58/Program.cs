// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

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

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

Console.Write("Введите количество строк 1-ой матрицы: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1-ой матрицы / строк 2-ой матрицы: ");
int columns1rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2-ой матрицы: ");
int columns2 = int.Parse(Console.ReadLine());

if (rows1 < 2 || columns1rows2 < 2 || columns2 < 2) Console.Write("Вы ввели недостаточное количество строк/столбцов для построения матриц");
else
{
    int[,] matrix1 = GetArray(rows1, columns1rows2);
    PrintArray(matrix1);
    Console.WriteLine();
    int[,] matrix2 = GetArray(columns1rows2, columns2);
    PrintArray(matrix2);
    Console.WriteLine();
    int[,] matrix3 = new int[rows1, columns2];
    MultiplyMatrix(matrix1, matrix2, matrix3);
    PrintArray(matrix3);
}