// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите любое число больше 1: ");
int num = int.Parse(Console.ReadLine());
if (num > 1)
{
    for (int x = 2; x < num + 1; x++)
    if (x % 2 == 0)
    Console.Write(x + " ");
}
else
{
    Console.Write("Вы ввели неправильное число");
}