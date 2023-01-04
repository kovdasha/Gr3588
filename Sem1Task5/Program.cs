//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем введенное число
if(inputLine!=null)

{
//Парсим введенное число
int inputNumber = int.Parse(inputLine);
   
int startNumber = inputNumber*(-1);

//Выводное значение
string outLine = string.Empty;

while(startNumber<inputNumber)
{
    outLine = outLine + startNumber + ",";
    startNumber++;
    //startNumber=startNumber+1;
}
outLine = outLine +inputNumber;

//Выводим данные в консоль
Console.WriteLine(outLine);
}