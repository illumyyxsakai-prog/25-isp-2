//Console.WriteLine("|      x      |      y      |");
//Console.WriteLine("---------------------------------");
//for (double x = -Math.PI / 4; x <= 7 * Math.PI / 4; x += 0.2)
//{
//    double y;
//    if (x > 2.5) y = Math.Cos(2.3 * x + 1);
//    else if (x >= 0 && x <= 2.5) y = 3 * Math.Log(Math.Abs(1 - x * x * x));
//    else y = x * x;
//    Console.WriteLine($"|  {x:f1}  |  {y:f2}  |");
//}
//Console.WriteLine("---------------------------------");

try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i++)
    {
        s += Math.Cos((2 * i - 1) * x) / Math.Pow(2 * i - 1, 2);
    }
    Console.WriteLine($"s={s:f2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
