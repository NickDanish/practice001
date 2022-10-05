// 1.  Вывод заданных данных 
// string name = "Tom";            
// int age = 25;
// bool unemployed = false;
// double weight = 90.25;

// Console.WriteLine($"Имя {name}");
// Console.WriteLine($"Возраст {age}");
// Console.WriteLine($"Работает {unemployed}");
// Console.WriteLine($"Вес {weight}");

// 2.  Ввод данных из терминала, с вариациями
// Console.Write("Введите имя: ");                            
// string? name = Convert.ToString(Console.ReadLine());   
// Console.Write("Введите возраст: ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите рост: ");
// double height = Convert.ToDouble(Console.ReadLine()); //double height = Convert.ToDouble(Console.ReadLine());
// Console.Write("Размер заработной платы: ");
// int salary = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} Зарплата: {salary}");
// Console.WriteLine($"Возраст: {age}");
// Console.WriteLine($"Рост: {height}");
// Console.WriteLine($"Зарплата: {salary}");



// 3. Вывести на экран числа 5, 10 и 21 одно под другим.

// int a = 5;
// int b = 10;
// int c = 21;

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// 4. Составить программу вывода на экран числа, вводимого с клавиатуры.
// После выводимого числа должно следовать сообщение " — вот какое число Вы  ввели".

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{a} - вот какое число Вы  ввели");

// 5.Составить программу:
// а) вычисления значения функции y=7x2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.

// Console.WriteLine("Введите число X ");
// double x = Convert.ToDouble(Console.ReadLine());
// double y = 7*x*2 + 3 * x + 6;
// Console.WriteLine($"Ответ уравнения у = {y} ");

// Console.WriteLine("Введите число a ");
// double a = Convert.ToDouble(Console.ReadLine());
// double x = 12 * a * 2 + 7 * a + 12;
// Console.WriteLine($"Ответ уравнения у = {x} ");

// 6. Дана сторона квадрата. Найти его периметр.

// Console.WriteLine("Введите длину стороны квадрата: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int p = a * 4;
// Console.WriteLine($"Периметр квадрата = {p} ");

// 7. Дано расстояние в сантиметрах. Найти число полных метров в нем.

// Console.Write("Введите растояние в см: ");
// int sm = Convert.ToInt32(Console.ReadLine());
// int m = sm / 100;
// Console.Write($"Растояние в полных метрах = {m}м ");

// 8. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?

// int days = 234;
// int weeks = days / 7;
// Console.Write($"Прошло полных недель = {weeks} ");

// 9. С начала суток прошло n секунд. Определить:
// а) сколько полных часов прошло с начала суток;
// б) сколько полных минут прошло с начала очередного часа;
// в) сколько полных секунд прошло с начала очередной минуты.

// Console.Write("Введите количество секунд: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int hours = (n / 60) / 60;
// Console.Write($"Прошло полных часов с начала суток: {hours} ");

// Console.Write("Введите количество секунд: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int min = n / 60;
// int hours = min / 60;
// int min2 = min - (hours * 60);
// Console.Write($"Прошло полных полных минут с начала часа: {min2} ");

// Console.Write("Введите количество секунд: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int min = n / 60;
// int sec = n - (min * 60);
// Console.Write($"Прошло полных секунд с начала последней минуты: {sec} ");

// УМНОЕ РЕШЕНИЕ с рандомайзером
//  Random random = new Random();
//       float cm = random.Next(1, 10000);
//       float m = cm / 100;
//       Console.WriteLine(Math.Floor(m));

// 9.  Рассчитать значение у при заданном значении х:
// y=sin(x) при x>0 или y=cos(x) в противном случае.

// Console.Write("Введите число х: ");
// double x = Convert.ToDouble(Console.ReadLine());
// if ( x > 0 )
// {
//     double y = Math.Sin(x);
//     Console.WriteLine (y);
// }
// else
// {
//     double y = Math.Cos(x);
//     Console.WriteLine (y);
// }

// . Даны два различных вещественных числа. Определить:
// а) какое из них больше;
// б) какое из них меньше.

Console.Write ("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number > number1 )
{
    Console.WriteLine($" Наибольшее число {number} ");
}
else Console.WriteLine($"Наибольшее число {number1} ");
