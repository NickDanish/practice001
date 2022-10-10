// Программа которая:
// 1. считывавет введенное число
// 2. проверяет кратно ли введенное число одновременно 7 и 23.




bool NumCheck(int num, int div1, int div2)
{
    return num % div1 == 0 && num % div2 == 0;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = NumCheck(num, 7, 23);
if(result)
{
    Console.WriteLine("yes");
}
else Console.WriteLine("no");

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 7;
// int b = num % 23;
// if (a == 0 && b == 0 )
// {
//     Console.WriteLine("yes");
// }
// else Console.WriteLine("no");



