//Console.Write("введите число:");
//long n = long.Parse(Console.ReadLine());
//int k3 = 0;
//int kLast = 0;
//int kOdd = 0;
//int sumGreater5 = 0;
//long multGreater7 = 0;
//int k05 = 0;
//int last = n%10;
//while (n != 0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if (temp == last) kLast++;
//    if (temp == last) kOdd++;
//    if (temp > 5) sumGreater5 += temp;
//    if(temp>7) multGreater7*=temp;
//    if (temp == 0 || temp == 5) k05++;
//    n /= 10;

//}
//Console.WriteLine($"Количество 3: {k3} ");
//Console.WriteLine($"Последняя цифра встречается: {kLast}");
//Console.WriteLine($"Количество 3: {kOdd} ");
//Console.WriteLine($"Количество 3: {sumGreater5} ");
//Console.WriteLine($"Количество 3: {multGreater7} ");
//Console.WriteLine($"Количество 3: {k05} ");

//for (int i = 1; i <= 9; i++)
//{
//    for (int j = 1; j <= 9; j++)
//    {
//        Console.Write($"{i}*{j}={i * j}");
//    }
//    Console.WriteLine();
//}

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{i * 10} ");
//    }
//    Console.WriteLine();
//}
//задача 1 средний уровень вариант 5

int n = 100;
while (n <= 700)
{
    int temp = n;
    int a = temp % 10;
    temp /= 10;
    int b = temp % 10;
    temp /= 10;
    int c = temp % 10;
    if (c % 2 != 0)
    Console.WriteLine(n);
    n++;
}