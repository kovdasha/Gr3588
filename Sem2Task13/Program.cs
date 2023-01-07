//Вводим переменные
int number = int.Parse(Console.ReadLine()??"0");

//Раскладываем трехзначное число
string value = number.ToString();

char[] numberArray = value.ToCharArray();

if(number>99)
{
    //Выводим данные в консоль
    Console.WriteLine(numberArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет");
}
