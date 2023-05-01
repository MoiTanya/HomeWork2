Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (Convert.ToInt32(number)<100){
     Console.WriteLine($"Вы ввели число {number} -> третьей цифры нет");
     
}
else {
    // int answer = number%10;
    Console.WriteLine($"{number} -> {number[2]}");
}