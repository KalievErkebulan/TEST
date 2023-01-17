System.Console.Clear();
Console.WriteLine("Введите первое число:");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int numberB = int.Parse(Console.ReadLine()!);
if(numberB ==numberA*numberA){
    System.Console.WriteLine("yes");
}
else{
    System.Console.WriteLine("no");
}
