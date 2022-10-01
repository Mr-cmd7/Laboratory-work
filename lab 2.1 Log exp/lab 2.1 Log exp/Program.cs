//2-ИСП-2/1 Саидбаев А.П. Лабораторная работа №2.1 Логическое выражение
//Вариант 7 Уровень высокий
try{

    double x, y;

    Console.Write("Введите x: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите y: ");
    y = Convert.ToDouble(Console.ReadLine());

    if (Math.Pow(x, 2) + Math.Pow(y, 2) >= 1 && x <= 2 && x >= -2 && y <= 1 && y >= -1)
        Console.WriteLine("Принадлежит");
    else 
        Console.WriteLine("Мимо");
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}