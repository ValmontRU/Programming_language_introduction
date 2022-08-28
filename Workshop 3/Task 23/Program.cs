// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите любое число, большее или равное 1: ");
int num = int.Parse(Console.ReadLine());
if (num >= 1)
{
    int x = 1;
    double cube = 1;
    while (x < num + 1)
    {
        cube = Math.Pow(x, 3);
        Console.Write(cube + " ");
        x++;
    }
}
else
{
    Console.Write("Вы ввели неправильное число");
}