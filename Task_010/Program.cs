// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int num1 = number /10;
//     int num2 = num1 %10;
//     Console.WriteLine($"Вторая цифра {num2} ");
// }
// else Console.WriteLine($"Введено не трехзначное число");

int SecondNum(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}

if (number > 99 && number < 1000)
{
    int result = SecondNum(number);
    Console.WriteLine($"Вторая цифра {result} ");
}
else Console.WriteLine($"Введено не трехзначное число");