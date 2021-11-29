// Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 7 == 0)
{
    Console.WriteLine(a + " кратно 7");
}
if(a % 23 == 0)
{
    Console.WriteLine(a + " кратно 23");
}
