// Напишите программу, которая:
// 1. Принимает на ввод 2 числа
// 2. Проверяет, является ли одно число квадратом другого
//5,25 - да
//-4,16 да

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


bool CheckNum(int num1, int num2)
{
    int a = num1*num1;
    int b = num2*num2;
    return  num1 == b | num2 == a;
}


bool result = CheckNum(number1, number2);
if (result) Console.WriteLine("yes");
else Console.WriteLine("no");
