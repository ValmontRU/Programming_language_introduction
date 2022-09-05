// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

double MaxCheck(double[] arr)
{
    double max = arr[0];
    foreach (double j in arr)
    {
        if (j > max) max = j;
    }
    return max;
}

double MinCheck(double[] arr)
{
    double min = arr[0];
    foreach (double j in arr)
    {
        if (j < min) min = j;
    }
    return min;
}

Console.Write("Введите размер массива: ");
int arrlen = int.Parse(Console.ReadLine());
double[] array = GetArray(arrlen);
double result = MaxCheck(array) - MinCheck(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine(result);