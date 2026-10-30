//string s = "456-435-23186";
//string pattern = "[0-9]{3}-[0-9]{3}-[0-9]{4}$";

//if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("OK");
//else Console.WriteLine("No");



Console.WriteLine("Введите слово:");
string s = Console.ReadLine();
s = s + s.Length;
Console.WriteLine(s);
