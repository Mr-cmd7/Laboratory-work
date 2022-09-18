//Саидбаев А.П. 22-ИСП-2/1 вариант 7
using System;

try
{
    Console.Write("Введите m: ");
    double m = double.Parse(Console.ReadLine());
    double N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;
    Console.WriteLine("N = {0:F2}", N);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
