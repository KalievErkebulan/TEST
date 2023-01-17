Console.Clear();
Console.WriteLine("Введите первое число:");
double numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
double numberB = int.Parse(Console.ReadLine()!);

if
    (numberA>numberB)
    {
        Console.Write($"max = {numberA}");
        Console.WriteLine($" min = {numberB}");
    }
else if (numberA<numberB)
{
        Console.Write($"max = {numberB}");
        Console.WriteLine($" min = {numberA}");
}
else{
        Console.Write($"min = {numberB}");
}

