//2-ИСП-2/1 Саидбаев А.П. Лабораторная работа №2.3 Оператор выбора вариантов 
//Вариант 7 Уровень средний
try
{
    double x, y=0, a = 0, b = 0, c = 0;
    byte option;

    Console.Write("Введите x: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите вариант: ");
    option = Convert.ToByte(Console.ReadLine());

    switch (option)
    {
        case 1: a = 3.2; b = -0.7; c = 2.2; break;
        case 2: a = 10.5; b = -2.5; c = 5.6; break;
        case 3: a = 5.4; b = 3; c = 2.6; break;
        default: Console.WriteLine("Нет такого варианта."); break;
    }
    
    if (Math.Abs(1 - Math.Pow(x, 2)) == a + c) y = x * Math.Exp(a) + Math.Exp(Math.Abs(b * c));
    else if (Math.Abs(1 - Math.Pow(x, 2)) > a + c) y = Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c);
    else if (Math.Abs(1 - Math.Pow(x, 2)) < a + c) y = Math.Sqrt(a * Math.Pow(b, 4) + Math.Pow(Math.Sqrt(c * Math.Pow(x, 2)), 1 / 5));
    Console.WriteLine($"y={y:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
