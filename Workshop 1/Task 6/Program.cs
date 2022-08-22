Console.Write("Введите число для проверки на чётность: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}