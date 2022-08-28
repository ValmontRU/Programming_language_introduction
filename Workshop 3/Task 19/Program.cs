// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!

Console.Write("Введите любое пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int x1 = num / 10000;
int x2 = num % 10;
int y1 = num / 1000 % 10;
int y2 = num / 10 % 10;
if (num > 9999 & num < 100000)
{
    if (x1 == x2 & y1 == y2)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
else
{
    Console.Write("Вы ввели неправильное число");
}