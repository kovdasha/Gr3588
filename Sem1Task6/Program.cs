//Считываем данные с консоли
string? num1Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(num1Line!=null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);

   if(num1 % 2 == 0)
   {
    Console.WriteLine("Число чётное");
   }
   else
   {
    Console.WriteLine("Число не чётное");
}
}