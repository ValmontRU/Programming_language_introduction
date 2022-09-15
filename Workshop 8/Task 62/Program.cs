// Напишите программу, которая заполнит спирально массив.

int[,] GetSquareArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    for (int number = 1; number <= size * size; number++)
    {
        result[i, j] = number;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if (i < j && i + j >= size - 1) i++;
        else if (i >= j && i + j > size - 1) j--;
        else i--;
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

Console.Write("Введите размер стороны квадратного массива: ");
int squareArraySize = int.Parse(Console.ReadLine());

if (squareArraySize < 2) Console.Write("Вы ввели недостаточную размерность для построения двумерного массива");
else
{
    int[,] myArray = GetSquareArray(squareArraySize);
    PrintArray(myArray);
}