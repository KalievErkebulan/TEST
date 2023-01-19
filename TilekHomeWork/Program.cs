Console.Clear();
Console.WriteLine("Введите дату рождения (день - месяц - год): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine()!);
DateTimeKind kind;
for(DateTime now = DateTime.Now; birthDate!=now;)
    {
        if (now!=birthDate)
            {
                Console.WriteLine("С днём рождения!!!");
                break;
            }
                else if (now!=birthDate)
                    {
                        Console.WriteLine("Today another day!");
                        break;
                    }
    }
//.ToString("dd.MM");