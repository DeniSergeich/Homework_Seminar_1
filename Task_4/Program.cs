Console.Clear();
Console.Write("Введите число > 1: ");
int number = int.Parse(Console.ReadLine());
int i = 2;
if (number <= 0)
{
    Console.Write("Вы ввели некорректное число!");
    return;
}
while (i <= number)
{
    Console.Write($"{i} ");
    i += 2;
}