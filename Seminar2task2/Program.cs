Console.Clear();
int number = new Random().Next(10,100);
int a = number%10;
int b = number/10;
System.Console.WriteLine(a);
System.Console.WriteLine(b);
int max=a;
if(max<b) max=b;
{
    System.Console.WriteLine(max);
}