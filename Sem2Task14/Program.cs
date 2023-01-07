//Вводим переменные
int number = int.Parse(Console.ReadLine()??"0");

//Делим число
int resalt1 = number%7;
int resalt2 = number%23;

if ((resalt1 == 0) && (resalt2 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}