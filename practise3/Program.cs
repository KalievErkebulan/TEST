System.Console.Clear();
System.Console.WriteLine("Введите номер:");
int number = int.Parse(Console.ReadLine()!);
switch (number)
{
    case 5:
    Console.WriteLine("Сегодня пятница");
    break;
    case 2:
    Console.WriteLine("Сегодня вторник");
    break;
    case 3:
    Console.WriteLine("Сегодня среда");
    break;
    default:
    Console.WriteLine("Это другой день");
    break;
}