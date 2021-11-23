// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine(a + " является квадратом " + b);
}
else
{
    Console.WriteLine(a + " не является квадратом " + b);
}
