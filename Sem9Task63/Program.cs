//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
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

//Метод 
string LineGenRec(int num)
{
    if (num <= 0) return string.Empty;
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }
}

