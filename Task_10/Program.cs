// Напишите программу, которая выводит случайное трехзначное число,
// удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int NumChange(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    
    return firstDigit*10 + secondDigit; ;
}
int result = NumChange(number);
if(result) Console.WriteLine($" {result}");