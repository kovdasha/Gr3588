int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));
PrintData("Result: " + DecToBinNativ(inputNumber));
PrintData("Result: " + Convert.ToString(inputNumber, 8));
PrintData("Result: " + Convert.ToString(inputNumber, 16));

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

//Первый метод конвертации в двоичную систему исчисления
string DegToBin(int num)
{
    string outBin = String.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num = num / 2;
    }
    return outBin;
}

//Второй метод конвертации в двоичную систему исчисления
string DecToBinNativ(int num)
{
    return Convert.ToString(num, 2);
}
