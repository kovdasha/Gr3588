//Вводим переменные
int number = int.Parse(Console.ReadLine()??"0");

//Раскладываем трехзначное число
string value = number.ToString();

//Из цифр создаем массив
char[] numberArray = value.ToCharArray();

if(number>99 && number<1000)
{
    //Выводим данные в консоль
    Console.WriteLine(numberArray[1]);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}
