Console.Clear();
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine());
int max = numberOne;
if (numberTwo > max)
{
    max = numberTwo;
}
if (numberThree > max)
{
    max = numberThree;
}
Console.Write($"Максимальное число: {max}");