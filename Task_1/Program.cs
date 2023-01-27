Console.Clear();
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine($"Число {numberOne} большее, а число {numberTwo} меньшее.");
}
else
{
    Console.WriteLine($"Число {numberTwo} большее, а число {numberOne} меньшее.");
}