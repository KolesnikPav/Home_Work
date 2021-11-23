// По заданному номеру дня недели вывести его название

string[] array = 
{
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
};
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if (day > 7 || day < 1)
{
    Console.WriteLine("В неделе 7 дней!");
}
else
{
    Console.WriteLine(array [day-1]);
}