Console.Clear();
double depositAmount = double.Parse(Console.ReadLine()!);
double month = double.Parse(Console.ReadLine()!);
double percent = 0.07D;
double percentForMonth = percent*depositAmount;
double finalDepositAmount=0;
for (double oneMonth = 1; oneMonth<=month; oneMonth++)
{
    if (finalDepositAmount==0 &&finalDepositAmount<depositAmount)
        {
            if(depositAmount!=0 && percentForMonth>0)
                {
                    finalDepositAmount = percentForMonth*month;
                    Console.WriteLine(finalDepositAmount);
                }
        }
                    Console.WriteLine($"{oneMonth} месяца и их проценты {percentForMonth}");
}