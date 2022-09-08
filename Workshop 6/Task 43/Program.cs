// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Intersection(double a, double b, double c, double d)
{
    if (b == d)
    {
        if (a == c)
        {
            Console.Write("Прямые совпадают");
        }
        else
        {
            Console.Write("Прямые параллельны");
        }
    }
    else
    {
        double x = (c - a) / (b - d);
        double y = b * x + a;
        Console.Write($"({x}, {y})");
    }
    return 0;
}

Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());

Intersection(b1, k1, b2, k2);