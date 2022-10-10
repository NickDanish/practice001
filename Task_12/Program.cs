//Программа которая:
// 1. на вход принимает 2 числа
// 2. И выводит явлляется ли второе число кратным первому.
// 3. если не кратно то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 % number2 == 0)
// {
//     Console.WriteLine($"кратно");
// }
// else
// {
//     int pers = number1 % number2;
//     Console.WriteLine($"не кратно, остаток {pers} ");
// }

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool NumPart( int num1, int num2)
{
    return num1 % num2 == 0;
}
bool exm = NumPart(number1, number2);
if(exm){
    Console.WriteLine("yes");
}
else 
{
    int pers = number1 % number2;
    Console.WriteLine($"не кратно, остаток {pers} ");
}