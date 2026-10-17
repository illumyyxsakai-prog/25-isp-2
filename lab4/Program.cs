//int[] mas5 = new int[5];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.Write($"{mas5[i]} ");
//}
//Console.WriteLine();
////
//int[] mas1 = new int[5];
//int[] mas2 = { 1, 4, 2, 9, 3 };
////int[] mas3 = mas2;
////mas3[3] = 12;
////Console.WriteLine(mas3[3]);
////Console.WriteLine(mas2[3]);

////ввод вручную
//int[] mas4 = new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4[i] = int.Parse(Console.ReadLine());
//for (int i = 0; i < mas4.Length; i++)
//    Console.Write($"{mas4[i]} ");

//использование генератора случайных чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(5, 15)];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] = rnd.Next(1, 100);
//    Console.Write($"{mas6   [i]} ");
//}


//try
//{
//    int[] mas = new int[10];
//    Random rnd = new Random();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-7, 8);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    int index = -1;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (mas[i] == n) index = i;
//    }
//    Console.WriteLine($"Индекс последнего вхождения {n} = {index} ");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите размерность массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-19, 27);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    long prod = 1;
//    for (int i = 1; i < mas.Length; i += 2)
//    {
//        prod *= mas[i];
//    }
//    Console.WriteLine($"Произведение элементов с нечетными номерами: {prod}");
//}

//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int s = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i]} ");
//        if (mas[i] == 0) s++;
//    }
//    Console.Write($"s={s}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//string? text = "Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id = null;
//int personId = id ?? 1;
//Console.WriteLine(personId);

try
{
    double[] mas = new double[12];
    double sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = i * i - 2 * i + 19.3 * Math.Cos(i);
        sum += mas[i];
        Console.Write($"{mas[i]:F2} ");
    }
    Console.WriteLine();
    double avg = sum / mas.Length;
    Console.WriteLine($"Среднее: {avg:F2}");

    double[] masNew = new double[12];
    int k = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < avg)
        {
            masNew[k] = mas[i];
            k++;
        }
    }
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= avg)
        {
            masNew[k] = mas[i];
            k++;
        }
    }
    for (int i = 0; i < masNew.Length; i++)
    {
        Console.Write($"{masNew[i]:F2} ");
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}