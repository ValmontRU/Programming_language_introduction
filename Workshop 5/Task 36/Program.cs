// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 100); 
    }
    return res;
}

int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (j % 2 != 0) sum = arr[j] + sum;
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int arrlen = int.Parse(Console.ReadLine());
int[] array = GetArray(arrlen);
int result = OddIndexSum(array);
Console.WriteLine(String.Join(", ", array));
Console.Write(result);