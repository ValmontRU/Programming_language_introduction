// Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.

int[] InitArray(int N, int a, int b)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int arrlen = int.Parse(Console.ReadLine());
Console.Write("Введите начало полуинтервала: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите конец полуинтервала: ");
int end = int.Parse(Console.ReadLine());

Console.Write(String.Join(", ", InitArray(arrlen, start, end)));