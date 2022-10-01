//2-ИСП-2/1 Саидбаев А.П. Лабораторная работа №2.2 Условные операторы
// Вариант 7 уровень высокий
try{
    ushort DayOfYear, DayOfWeek;

    Console.Write("Введите число дня: ");
    DayOfYear = Convert.ToUInt16(Console.ReadLine());

    DayOfWeek = (ushort)(DayOfYear - (DayOfYear / 7) * 7);

    if (DayOfWeek == 1) Console.WriteLine("Понедельник");
    else if (DayOfWeek == 2) Console.WriteLine("Вторник");
    else if (DayOfWeek == 3) Console.WriteLine("Среда");
    else if (DayOfWeek == 4) Console.WriteLine("Четверг");
    else if (DayOfWeek == 5) Console.WriteLine("Пятница");
    else if (DayOfWeek == 6) Console.WriteLine("Суббота");
    else if (DayOfWeek == 0) Console.WriteLine("Воскресенье");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}