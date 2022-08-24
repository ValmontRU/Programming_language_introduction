//  Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99)
{
    int x = num / 100 % 10;
    Console.Write(x);
}
else if (num < -99)
{
    int x = -num / 100 % 10;
    Console.Write(x);
}
else
{
    Console.Write("Третьей цифры нет");
}
// Причина дублирования строк 8 и 13 аналогична таковой в задаче 10