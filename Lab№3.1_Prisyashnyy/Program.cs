//Сборник задач/тема 3/подтема 3.1/средний уровень/вариант 6
try
{
    Console.WriteLine("Введите k:");
    double k = double.Parse(Console.ReadLine());
    double w = 0;
    for (double i = -2; i <= k; i++)
    {
        double factorial = i + 3;
        double f = factorial;
        for (double j = 1; j <= f; j++) factorial *= j;
        w += (Math.Pow(-1, i) * factorial) / (i - 4);
    }
    Console.WriteLine($"W = {w}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

