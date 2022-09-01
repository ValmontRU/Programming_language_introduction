// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponent(int NumberA, int NumberB)
{
    int exp = 1;
    for (int i = 1; i <= NumberB; i++)
    {
        exp*=NumberA;
    }
    Console.Write($"{NumberA} ^ {NumberB} = {exp}");
    return 0;
}

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

Exponent(numA, numB);