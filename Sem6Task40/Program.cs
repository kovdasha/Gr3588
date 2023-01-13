int a = ReadData("Введите длину первого отрезка: ");
int b = ReadData("Введите длину второго отрезка: ");
int c = ReadData("Введите длину третьего отрезка: ");

if (TriangleTest(a, b, c)) 
PrintData("Треугольник сo сторонами такой длины может существовать");
else 
PrintData("Треугольник сo сторонами такой длины не может существовать");

//Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода данных
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод проверки существования треугольника с заданными сторонами
bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c) && (a + c > b) && (b + c > a));
}
