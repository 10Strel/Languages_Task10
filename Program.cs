Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\r\n");

Console.WriteLine("Введите целое трехзначное число:");

bool res = int.TryParse(Console.ReadLine(), out int number);
if (!res || !((number > -1000 && number < -99) || (number > 99 && number < 1000)))
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

string tmp = Math.Abs(number).ToString();
Console.WriteLine($"Результат: {tmp[1]}");