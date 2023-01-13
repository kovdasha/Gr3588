double b1 = ReadData("Введите координату b1");
double k1 = ReadData("Введите координату k1");
double b2 = ReadData("Введите координату b2");
double k2 = ReadData("Введите координату k2");

string result = CrossCoordinate(b1, k1, b2, k2);

PrintData(result, "- координаты точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

//Метод ввода данных
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода данных
void PrintData(string res, string msg)
{
    Console.WriteLine(res + msg);
}

//Метод расчета координат точки пересечения
string CrossCoordinate(double b1, double k1, double b2, double k2)
{
    double y = (b2 * k1 - k2 * b1) / (k1 - k2);
    double x = (y - b1) / k1;
    string res = "(" + Math.Round(x, 1) + ";" + Math.Round(y, 1) + ")";
    return res;
}