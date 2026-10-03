//using System.Linq.Expressions;
//try
//{
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1:
//            Console.WriteLine("понедельник");
//            break;
//        case 2:
//            Console.WriteLine("вторник");
//            break;
//        case 3:
//            Console.WriteLine("среда");
//            break;
//        case 4:
//            Console.WriteLine("четверг");
//            break;
//        case 5:
//            Console.WriteLine("пятница");
//            break;
//        case 6:
//            Console.WriteLine("суббота");
//            break;
//        case 7:
//            Console.WriteLine("воскресенье");
//            break;
//    }
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("введите номер месяца:");
//    int n = int.Parse(Console.ReadLine());
//    switch(n)
//    {
//        case 12: case 1: case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3: case 4: case 5:
//            Console.WriteLine("весна");
//            break;
//        case 6: case 7: case 8:
//            Console.WriteLine("лето");
//            break;
//        case 9: case 10: case 11:
//            Console.WriteLine("Осень");
//            break;
//        default:
//            Console.WriteLine("Нет такого месяца");
//            break;
//    }
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.WriteLine("запишите номер карты:");
//    Console.WriteLine("кто по масти");
//    int n = int.Parse(Console.ReadLine());
//    int m = int.Parse(Console.ReadLine());
//    switch(n)
//    {
//        case 6:
//            Console.WriteLine("шестерка");
//            break;
//        case 7:
//            Console.WriteLine("семерка");
//            break;
//        case 8:
//            Console.WriteLine("восьмерка");
//            break;
//        case 9:
//            Console.WriteLine("девятка");
//            break;
//        case 10:
//            Console.WriteLine("десятка");
//            break;
//        case 11:
//            Console.WriteLine("валет");
//            break;
//        case 12:
//            Console.WriteLine("дама");
//            break;
//        case 13:
//            Console.WriteLine("король");
//            break;
//        case 14:
//            Console.WriteLine("туз");
//            break;
//    }
//    switch(m)
//    {
//        case 1:
//            Console.WriteLine("пик");
//            break;
//        case 2:
//            Console.WriteLine("треф");
//            break;
//        case 3:
//            Console.WriteLine("бубен");
//            break;
//        case 4:
//            Console.WriteLine("черви");
//            break;
//        default:
//            Console.WriteLine("нет такой масти");
//            break;
//    }
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.WriteLine("запишите число:");
//    int n = int.Parse(Console.ReadLine());

//    if (n >= 11 && n <= 14)
//    {
//        Console.WriteLine(n + " рублей");
//    }
//    else
//    {
//        switch (n % 10)
//        {
//            case 1:
//                Console.WriteLine(n + " рубль");
//                break;
//            case 2:
//            case 3:
//            case 4:
//                Console.WriteLine(n + " рубля");
//                break;
//            default:
//                Console.WriteLine(n + " рублей");
//                break;
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//высокий уровень вариант 13
try
{
    Console.Write("Введите номер варианта:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());

    double k = 0, r = 0, s = 0, y = 0;

    switch (n)
    {
        case 1:
            {
                k = 1.33; r = 0.85; s = 3.5;
            }
            break;
        case 2:
            {
                k = 0.9; r = 3.3; s = 1.2;
            }
            break;
        case 3:
            {
                k = 1.57; r = 0.75; s = 2.15;
            }
            break;
        default: break;
    }

    if (Math.Cos(x) == Math.Cos(r * s))
    {
        y = Math.Pow(x, 2) * Math.Exp(2 * k) + Math.Log(Math.Abs(x));
    }
    else if (Math.Cos(x) > Math.Cos(r * s))
    {
        y = Math.Pow(x * x, 1.0 / 3.0) + Math.Sqrt(Math.Abs(k + r * x));
    }
    else
    {
        y = Math.Atan(k * x + r * s);
    }

    Console.WriteLine($"y = {y:F2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}