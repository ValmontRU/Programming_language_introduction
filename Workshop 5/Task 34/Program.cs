// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int EvenCount(int[] arr)
{
    int count = 0;
    foreach (int j in arr)
    {
        if (j % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int arrlen = int.Parse(Console.ReadLine());
int[] array = GetArray(arrlen);
int result = EvenCount(array);
Console.WriteLine(String.Join(", ", array));
Console.Write(result);