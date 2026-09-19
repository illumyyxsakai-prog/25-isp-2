//////Console.WriteLine($"{Math.PI:F2}");
//////Console.WriteLine($"{Math.E:F1");
//////int a = int.Parse(Console.ReadLine());
//////Console.WriteLine($"вы ввели число {a}");

//////int a = int.Parse(Console.ReadLine());
//////Console.WriteLine($"вот такое число вы ввели {a}");

//////Console.WriteLine("1 13 49");
//////Console.WriteLine("7  15  100");

//////try
//////{

//////    Console.Write("введите a");
//////    double a = double.Parse(Console.ReadLine());
//////    Console.Write("введите b");
//////    double b = double.Parse(Console.ReadLine());
//////    Console.Write("введите c");
//////    double c = double.Parse(Console.ReadLine());
//////    double d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//////    Console.WriteLine($"{d:F2}");
//////}
//////catch (Exception ex)
//////{
//////    Console.WriteLine(ex.Message);
//////}


//////try
//////{


//////    Console.WriteLine("введите радиус");
//////    double R = double.Parse(Console.ReadLine());
//////    double D = 2 * R;
//////    Console.WriteLine($"Диаметр окружности:{R:F2}");

//////}
//////catch (Exception ex)
//////{
//////    Console.WriteLine(ex.Message);
//////}
//////try
//////{


//////    Console.WriteLine("введите x:");
//////    double x = double.Parse(Console.ReadLine());
//////    Console.WriteLine("введите y:");
//////    double y = double.Parse(Console.ReadLine());
//////    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
//////    Console.WriteLine($"диаметр окружности:{z:F2}");
//////    double q = 2.8 * Math.Sin(x) + Math.Abs(y);
//////    Console.WriteLine($"q={z:F2}");
//////}
//////catch(Exception ex)
//////{
//////    Console.WriteLine(ex.Message);
//////}

//////try
//////{
//////    Console.Write("введите количество сантиметров");
//////    int sm=int.Parse(Console.ReadLine());
//////    int m = sm / 100;
//////    Console.WriteLine($"полных метров {m}"); 

//////}
//////catch(Exception ex)
//////{
//////    Console.WriteLine(ex.Message);
//////}

////try
////{
////    Console.Write("введите количество в кг ");
////    int kg=int.Parse(Console.ReadLine());
////    int cn = kg / 100;
////    Console.WriteLine($"полных центнеров {cn}");
////}
////catch(Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}

////try
////{
////    Console.Write("введите количество в кг ");
////    int kg = int.Parse(Console.ReadLine());
////    int ton = kg / 1000;
////    Console.WriteLine($"полных тонн {ton}");
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}

////try
////{
////    Console.Write("введите расстояние в метрах ");
////    int m = int.Parse(Console.ReadLine());
////    int km = m / 1000;
////    Console.WriteLine($"полных километров {km}");
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}

////try
////{
////    Console.Write("введите количество сек ");
////    int n = int.Parse(Console.ReadLine());
////    int hour = n/3600;
////    int minute = n % 3600/60;
////    int second = n % 3600 % 60;
////    Console.WriteLine($"{hour}:{minute}:{second}");
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}
////try
////{
////    Console.Write("введите четерехзначное число:");
////int n = int.Parse(Console.ReadLine());
////int a = n % 10;
////int b = n % 100 / 10;
////int c = n % 1000 / 100;
////int d = n / 1000;
////int s = a + b + c + d;
////Console.WriteLine(s);
////}
////catch (Exception ex)
////{
////    Console.WriteLine(ex.Message);
////}

//Лабораторная работа 3.36

try
{
    Console.Write("введите трехзначное число:"); //546
    int n = int.Parse(Console.ReadLine());
    int b = n / 100;
    int a = n / 10 % 10;
    int c = n % 10;
    int x = a * 100 + b * 10 + c;
    Console.WriteLine($"число изначальное x = {x}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}