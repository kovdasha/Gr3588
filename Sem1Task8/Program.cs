//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем введенное число
if(inputLine!=null)

{
//Парсим введенное число
int inputNumber = int.Parse(inputLine);
   
//Начинаем с первого чётного
int startNumber = 2;

//Выводное значение
string outLine = string.Empty;

while(startNumber<inputNumber+1)
{
    outLine = outLine + startNumber + ",";
    startNumber = startNumber+2;
}
//Обрезание последней запятой
outLine = outLine.TrimEnd(',');

//Выводим данные в консоль
Console.WriteLine(outLine);
}