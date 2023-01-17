Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите второе число ");
int numberB = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите третье число ");
int numberC = int.Parse(Console.ReadLine()!);

if  (numberA > numberB && numberA > numberC)
    
    Console.WriteLine($"max value equal to {numberA}");

else if (numberB > numberA && numberB > numberC) 

    Console.WriteLine($"max value equal to {numberB}");

else if (numberC > numberA && numberC > numberB) 

    Console.WriteLine($"max value equal to {numberC}");


