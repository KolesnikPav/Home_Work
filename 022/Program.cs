// Программа проверяет пятизначное число на палиндромом.

Console.Write("Введите пятизначное число : ");
string a = Console.ReadLine();
int b = int.Parse(a);

if(b <= 9999 || b >= 100000)
{
    Console.WriteLine("Введите пятизначное число!");
}
    else if(int.Parse("" + a[0]) == int.Parse("" + a[4]) || int.Parse("" + a[1]) == int.Parse("" + a[3]))
    {
        Console.WriteLine(a + " палиндром");
    }
    else
    {
        Console.WriteLine(a + " не палиндром");
    }

