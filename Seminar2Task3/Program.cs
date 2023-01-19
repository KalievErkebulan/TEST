Console.Clear();
int numberOne = int.Parse(Console.ReadLine()!);
int numberTwo = int.Parse(Console.ReadLine()!);
float resultDividesNumbers = numberTwo%numberOne;
if(resultDividesNumbers==0)
    Console.WriteLine("Число кратно: " );
else 
    Console.WriteLine("Число не кратно: " + resultDividesNumbers);