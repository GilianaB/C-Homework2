Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day < 6)
Console.WriteLine("Не выходной");

if (day == 6 | day == 7)
Console.WriteLine("Выходной");

if (day < 1 | day > 7)
Console.WriteLine("Неправильный ввод");