Console.Write ("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number > number1 && number > number2)
{
    Console.Write($"max = {number}");
}
else if (number1 > number && number1 > number2)
{
    Console.Write($"max = {number1}");
}
else Console.Write($"max = {number2}");
