int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
int resultLine = SumRecMN(numberM, numberN);
PrintResult(resultLine);

//Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int SumRecMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return N;
     outRes = M + SumRecMN(M + 1, N);
    return outRes;
}