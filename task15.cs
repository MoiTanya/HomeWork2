Console.WriteLine("Введите число, обозначающее неделю");
int day = Convert.ToInt32(Console.ReadLine());
if (day<8 && day>0)
{
    switch (day){
        case 1: 
        Console.WriteLine($"Вы ввели число {day} -> понедельник");
        break;
        case 2: 
        Console.WriteLine($"Вы ввели число {day} -> вторник");
        break;
        case 3: 
        Console.WriteLine($"Вы ввели число {day} -> среда");
        break;
        case 4: 
        Console.WriteLine($"Вы ввели число {day} -> четверг");
        break;
        case 5: 
        Console.WriteLine($"Вы ввели число {day} -> пятница");
        break;
        case 6: 
        Console.WriteLine($"Вы ввели число {day} -> суббота");
        break;
        case 7: 
        Console.WriteLine($"Вы ввели число {day} -> воскресенье");
        break;
    }
     
}
else {
    Console.WriteLine($"{day} -> нет такого дня недели");
}