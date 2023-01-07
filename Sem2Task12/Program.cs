//Вводим переменные
int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");

//Делим число 2 на число 1
int resalt = number2%number1;

if (resalt == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не красно первому. Остаток от деления: " + resalt);
}