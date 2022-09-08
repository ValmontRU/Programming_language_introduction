// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PositiveCount(int numbers)
{
    int count = 0;
    for (int i = 0; i < numbers; i++)
    {
        Console.WriteLine("Введите любое число:");
        int x = int.Parse(Console.ReadLine());
        if (x > 0) count++;
    }
    return count;
}

Console.Write("Введите положительное число M: ");
int M = int.Parse(Console.ReadLine());
if (M > 0)
{
    Console.Write($"Количество положительных чисел равно {PositiveCount(M)}");
}
else
{
    Console.Write("Вы ввели неправильное число M");
}