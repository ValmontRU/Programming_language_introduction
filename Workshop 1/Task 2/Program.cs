Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > num1)
{
    max = num2;
    Console.Write(max);
}
else
{
    Console.Write(max);
}