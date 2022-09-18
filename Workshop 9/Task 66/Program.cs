// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ElementsSum(int m, int n)
{
    return m <= n ? m + ElementsSum(m + 1, n) : 0;
}

Console.Write("Введите натуральное число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numN = int.Parse(Console.ReadLine());

if (numM < 1 || numN < 1) Console.Write("Вы ввели неправильное число");
else Console.Write(ElementsSum(numM, numN));