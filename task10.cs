Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int answer = (number%100)/10;
Console.WriteLine($"{number} -> {answer}");