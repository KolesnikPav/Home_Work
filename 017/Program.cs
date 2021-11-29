// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите порядковый номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if(a < 1 || a > 7)
{
    Console.WriteLine("В неделе семь дней!");
}
else if(a < 6)
{
    Console.WriteLine("Рабочий день!");
}
else
{
    Console.WriteLine("Выходной");
}