using School;
using System;

Console.Write("Введите колличество дисциплин: ");
int numberDiscipline = int.Parse(Console.ReadLine());
Shedule[] shedules = new Shedule[numberDiscipline];
for (int i = 1; i <= numberDiscipline; i++)
{
    Console.Write("Введите название дисциплины: ");
    string discipline = Console.ReadLine();
    Console.Write("Введите номер аудитории: ");
    int office = int.Parse(Console.ReadLine());
    Console.Write("Введите часы: ");
    int hoursone = int.Parse(Console.ReadLine());
    Console.Write("Введите минуты: ");
    int minutesone = int.Parse(Console.ReadLine());
    Console.Write("Введите секунды: ");
    int seconds = int.Parse(Console.ReadLine());
    Time time = new Time(hoursone, minutesone, seconds);
    Shedule shedule = new Shedule(discipline, office, hoursone, minutesone, seconds);
    shedules[i - 1] = shedule;
}
Console.WriteLine("Введите время чтобы узнать какой будет урок");
Console.Write("Введите часы: ");
int hours = int.Parse(Console.ReadLine());
Console.Write("Введите минуты: ");
int minutes = int.Parse(Console.ReadLine());
var filtered = shedules.Where(schedule => schedule.SomeMethod(hours, minutes));
foreach (var item in filtered)
{
    Console.WriteLine(item.Discipline);
}
