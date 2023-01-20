/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным*/
Console.Clear();
Console.WriteLine("Введите свое число: ");
int number = int.Parse(Console.ReadLine()!);
switch (number)
{   
    case 7:
    Console.WriteLine("да");
    break;
    case 6:
    Console.WriteLine("да");
    break;
    default:
    Console.WriteLine("нет");
    break;
}