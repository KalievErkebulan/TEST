Console.Clear();
double depositAmount = double.Parse(Console.ReadLine()!);
double month = double.Parse(Console.ReadLine()!);
double percent = 0.07D;
double percentForMonth = percent*depositAmount;
double finalDepositAmount = 0;
double oneMonth = 1;
while(oneMonth<=month) 
{
  if (finalDepositAmount==0 &&finalDepositAmount<depositAmount)
        {
            if(depositAmount!=0 && percentForMonth>0)
                {
                    finalDepositAmount = percentForMonth*month;
                }
        }
                        oneMonth++;
                        Console.WriteLine($"За 1 месяц вы получите проценты {percentForMonth}");
}
                            Console.WriteLine($"Итого вы получите {finalDepositAmount}");