// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите любое число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (num < 1 || num > 7)
{
    Console.Write("Вы ввели неправильное число");
}
else if (num == 6 || num == 7)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}