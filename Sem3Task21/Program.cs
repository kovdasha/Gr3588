///Вводим данные
int X1 = ReadData("Введите координату Х1: ");
int Y1 = ReadData("Введите координату Y1: ");
int Z1 = ReadData("Введите координату Z1: ");
int X2 = ReadData("Введите координату Х2: ");
int Y2 = ReadData("Введите координату Y2: ");
int Z2 = ReadData("Введите координату Z2: ");

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости
double CalculateLenght(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
    return distance;
} 

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

PrintData("Расстояние между точками: ", CalculateLenght(X1, Y1, Z1, X2, Y2, Z2));