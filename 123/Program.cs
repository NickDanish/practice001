
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
int counter = a;
while (counter <= number )
{
    Console.Write($"{counter} ");
    counter++;
}

