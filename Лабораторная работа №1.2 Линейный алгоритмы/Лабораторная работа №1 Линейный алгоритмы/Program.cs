// Саидбаев А.П. 22-ИСП-2/1 Вариант 7 Уровень: Высокий
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try

        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Введите a1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите a2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = double.Parse(Console.ReadLine());
            double cos = (a1 * b1 + a2 * b2) / (Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(a2, 2)) * Math.Sqrt(Math.Pow(b1, 2) + Math.Pow(b2, 2)));
            double arccos = Math.Acos(cos);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("cos a = {0:F2}", cos);
            Console.WriteLine("arccos a = {0:F2}", arccos);
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
}