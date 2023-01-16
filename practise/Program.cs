Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;

Console.WriteLine("Квадрат числа равен: " + sqr);  
Console.WriteLine($"Квадрат числа {number} равен: {sqr}");
double sqr2 = Math.Pow(number,2);
Console.WriteLine($"Квадрат числа {number} равен: {sqr}");