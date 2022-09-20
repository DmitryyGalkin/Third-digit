Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
string numberStr = number.ToString();

if (numberStr.Length > 2)
    Console.WriteLine($"Третья цифра {numberStr[2]}");
else
    Console.WriteLine("Третьей цифры нет");


