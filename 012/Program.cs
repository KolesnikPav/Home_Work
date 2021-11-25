// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите любое целое число в диапазоне [10, 99]: ");
string a = Console.ReadLine();

if(int.Parse(a) <= 9 || int.Parse(a) >= 100)
{
    Console.WriteLine("Число от 10 до 99. Давай еще раз!");
}
    else if(a[0] > a[1])
    {
        Console.WriteLine("В числе " + a + " наибольшая цифра: " + a[0]);
    }
    else
    {
        Console.WriteLine("В числе " + a + " наибольшая цифра: " + a[1]);
    }
