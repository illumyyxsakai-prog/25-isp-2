/*try
{
    Console.Write("Введите первую переменную");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите вторую переменную");
    double y = double.Parse(Console.ReadLine());
    double Avg = (Math.Pow(x, 3) + Math.Pow(y, 3)) / 2;
    Console.WriteLine($"Среднее арифметическое:{Avg:F2}");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}*/

try
{
    double m = 2;
    double x = 1.1;
    double a = (Math.Sqrt(Math.Abs(x)));
    double b = Math.Pow(x, 4) + Math.Pow(m, 2);
    double y = Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);
    Console.WriteLine($"y = {y:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
