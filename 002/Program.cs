// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
var a = Console.ReadLine();
Console.Write("Введите второе число: ");
var b = Console.ReadLine();

if (Convert.ToDouble(a) == Convert.ToDouble(b) * Convert.ToDouble(b))
{
    Console.WriteLine(a + " является квадратом " + b);
}
else
{
    Console.WriteLine(a + " не является квадратом " + b);
}
