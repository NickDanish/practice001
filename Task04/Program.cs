Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.Write($"Последняя цифра числа => {lastDigit}");
}
else System.Console.WriteLine("Число не трехзначное");