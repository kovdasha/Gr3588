int number = ReadData("Введите число: ");
PrintData(FibNum(number));

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

//Метод расчёта чисел Фибоначчи
string FibNum(int num)
{
    string outLine = "0 1";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 2; i < num; i++)
    {
        outLine = outLine +" "+ (first + last).ToString();
        buf=last;
        last=first+last;
        first=buf;
    }
    return outLine;
}
