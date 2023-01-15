int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintData(resultLine);

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

//Метод вывода натуральных числа от N до 1 с помощью рекурсии
string LineGenRec(int num)
{
    int i =num;
    if (num <= 0) return string.Empty;
    else
    {
        string outLine = i + " " + LineGenRec(i - 1);
        return outLine;
    }
}