//try
//{
//    Console.Write("Введите k:");
//    int k = int.Parse(Console.ReadLine());
//    double A = 1;
//    for (int j = 1; j <= k; j++)
//    {
//        if (j == 3) continue;
//        double s = 0;
//        for (int i = j; i <= k + 1; i++)
//        {
//            if (i == 1) continue;
//            s += Math.Pow(i - 5, 1 / 3.0) / (i - 1);
//        }
//        A *= (j - 4) * j / (j - 3) * s;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Задание 2 вариант номер 5 средний уровень
try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double W = 0;
    for (int i = 1; i <= 9; i++)
    {
        if (i == 3) continue;
        double p = 1;
        for (int n = i; n <= 17; n++)
        {
            if (n == 12) continue;
            p *= (Math.Pow(n, 3) - 8) / (n - 12);
        }
        W += Math.Pow(Math.Abs(7 - x), i) / Math.Pow(i - 3, 5) * p;
    }
    Console.WriteLine($"W = {W}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}