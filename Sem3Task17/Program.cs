// //Вводим данные
// Console.WriteLine("Введите координату X");
// int coordX = int.Parse(Console.ReadLine()??"0");

// Console.WriteLine("Введите координату Y");
// int coordY = int.Parse(Console.ReadLine()??"0");

int coordX = ReadData("Введите координату Х");
int coordY = ReadData("Введите координату Y");

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод нахождения точки
void PrintQuaterTest()
{
if(coordX>0&&coordY>0) Console.WriteLine("Точка в четверти 1");
if(coordX>0&&coordY<0) Console.WriteLine("Точка в четверти 2");
if(coordX<0&&coordY<0) Console.WriteLine("Точка в четверти 3");
if(coordX<0&&coordY>0) Console.WriteLine("Точка в четверти 4");
}

PrintQuaterTest();