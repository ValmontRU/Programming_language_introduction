// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum(int Number)
{
    int sum = 0;
    while (Number > 0)
    {
        sum = sum + Number % 10;
        Number = Number / 10;
    }
    Console.Write(sum);
    return 0;
}

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());

DigitSum(num);