/* Напишите программу,которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа.
456-->46
782-->72
918-->98*/
Console.Clear();
int randomThreeDigitNumber = new Random().Next(100,1000);
int remainder = randomThreeDigitNumber%10;
int division = randomThreeDigitNumber/100;
int multiplication = division*10;
int addition = multiplication+remainder;
Console.WriteLine(randomThreeDigitNumber);
Console.WriteLine(addition);