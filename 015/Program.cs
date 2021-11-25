// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
string a = Console.ReadLine();

if(int.Parse(a) / 10 <= 9)
{
    Console.WriteLine("Третьей цифры в числе нет!");
    //else if(int.Parse(a) / 10 >= 100)

}
else
{
    Console.WriteLine(a[2]);
}
