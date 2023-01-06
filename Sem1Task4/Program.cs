//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(num1Line!=null&& num2Line!=null&& num3Line!=null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

   //Сравниваем числа 1 и 2
   if(num1>num2)
   {
        //Если первое больше, то сравниваем число 1 и 3
        if(num1>num3)
        {
        Console.WriteLine("Число один максимально");
        }
        else
        {
        Console.WriteLine("Число три максимально");
        }
   }
   else
   {
    //Если первое число меньше, то сравниваем число 2 и 3
    if(num2>num3)
    {
        Console.WriteLine("Число два максимально");
    }
       else
    {
        Console.WriteLine("Число три максимально");
    }
   }
}