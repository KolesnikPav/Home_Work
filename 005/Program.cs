// Найти максимальное из трех чисел

Console.Write("Введите первое число: ");
double arg1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double arg2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double arg3 = Convert.ToDouble(Console.ReadLine());

double Max(double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
double max = Max(arg1, arg2, arg3);
Console.WriteLine("Максимальное число: " + max);
