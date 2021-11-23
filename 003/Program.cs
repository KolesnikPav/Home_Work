// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + " > " + b);
}
if (a < b)
{
    Console.WriteLine(a + " < " + b);
}
if (a == b)
{
    Console.WriteLine("Числа равны!");
}
