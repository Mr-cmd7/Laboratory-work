// 22-ИСП-2/1 Саидбаев А.П. 7 вариант уровень высокий 

try
{
    double number, summa=0;
    Console.WriteLine("Для поиска суммы отрицательных чисел закончите ввод значений, значением : 0");
    Console.WriteLine("Введите значения через Enter: ");
    do
    {
        number = double.Parse(Console.ReadLine());

        if (number > 0) continue;

        summa += number;
    } while (number != 0);
    Console.WriteLine("Сумма отрицательных чисел: "+summa);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
