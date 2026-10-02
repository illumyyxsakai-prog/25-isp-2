try
{
    Console.Write("Введите x");
    double x = double.Parse(Console.ReadLine());
    double y;
    if (x > 0) y = Math.Sin(x) * Math.Sin(x);
    else y = 1 - 2 * Math.Sin(x * x);
    Console.WriteLine($"y={y:F2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}