// Даны два неотрицательных числа m и n.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.Write("Введите неотрицательное число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int numN = int.Parse(Console.ReadLine());

if (numM < 0 || numN < 0) Console.Write("Вы ввели неправильное число");
else Console.Write(Ackermann(numM, numN));