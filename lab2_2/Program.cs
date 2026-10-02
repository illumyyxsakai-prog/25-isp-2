//try
//{
//    Console.Write("Введите x");
//    double x = double.Parse(Console.ReadLine());
//    if (x < 4) Console.WriteLine("первая область");
//    else Console.WriteLine("Вторая область");

//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if (x > y)
//    {
//        max = x;
//        min = y;
//    }
//    else
//    {
//        max = y;
//        min = x;
//    }
//    Console.WriteLine($"max = {max}, min = {min}");
//    }
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("введите y:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("введите c:");
//    double c = double.Parse(Console.ReadLine());
//    if ((a < b) && (b < c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("не выполняется");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("введите n:");
//    int n = int.Parse(Console.ReadLine());
//    int a = n / 100;
//    int b = n / 10 % 10;
//    int c = n % 10;
//    if ((a == 4 || b == 3 || c == 3) || (a == 6 || b == 6 || c == 6 (a == 9 || b == 9 || c == 9)) console.writeline("Да");
//    else Console.WriteLine("нет");

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

try
{
    Console.Write("Введите x1:");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1:");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2:");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2:");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите x3:");
double x3 = double.Parse(Console.ReadLine());
Console.Write("Введите y3:");
double y3 = double.Parse(Console.ReadLine());
if (x1 == x2 && y1 == y2) Console.WriteLine("Нельзя провести");
else Console.WriteLine("Можно провести");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}