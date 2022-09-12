// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.

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

void CheckNumber(int num, int[,] arrayToCheck)
{
    bool check = false;
    for (int i = 0; i < arrayToCheck.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToCheck.GetLength(1); j++)
        {
            if (arrayToCheck[i, j] == num) 
            {
                check = true;
                Console.WriteLine($"Число {num} соответствует элементу массива с индексом {i}, {j}");
            }
        }
    }
    if (check == false) Console.Write("Такого числа в массиве нет");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

if (rows < 2 || columns < 2) Console.Write("Вы ввели недостаточное количество строк/столбцов для построения двумерного массива");
else
{
    Console.Write("Введите любое число: ");
    int number = int.Parse(Console.ReadLine());
    int[,] myArray = GetArray(rows, columns);
    PrintArray(myArray);
    CheckNumber(number, myArray);
}