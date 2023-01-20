/*Напишите программу,которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
645-->5
78-->третьей цифры нет
32679-->6
*/
Console.Clear();
int number = int.Parse(Console.ReadLine()!);
int exampleOfThreeDigitNumber = 345;
string strTwo = $"{exampleOfThreeDigitNumber}";
string strOne = $"{number}";
int lengthOne = strOne.Length;
int lengthTwo = strTwo.Length;
int lengthDifference =lengthOne-lengthTwo;
int degree = Convert.ToInt32(Math.Pow(10,lengthDifference));
    if( lengthOne < lengthTwo)
    {
                        Console.WriteLine($"{number} Третьей цифры нет");
    }
    else if (lengthOne>lengthTwo)
    {
        do
        {
            number = (number /degree );
            break;
        }
        while (lengthTwo<=lengthOne);
        {    
            number = number % 10;
            Console.WriteLine($"The third digit of this number is {number}");
        }
    }
    else
    {
        number = number % 10; 
        System.Console.WriteLine($"The third digit of this number is {number}");
    }
