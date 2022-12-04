int Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 == Number2 * Number2 | Number2 == Number1 * Number1)
Console.WriteLine("Да, кратно");
else Console.WriteLine("Нет, не кратно");