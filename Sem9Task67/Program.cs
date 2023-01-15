//Принимает на вход число и возвращает сумму цифр числа

int numberN = ReadData("Введите номер N:");
int Sum = RecSumDig(numberN);
PrintResult(Sum);

//Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода данных
void PrintResult(int prefix)
{
    Console.Write(prefix);
}

//Метод возврата суммы цифр числа
int RecSumDig(int n)
{
    if (n<= 10) return n;
    int result = n%10 + RecSumDig(n/10);
    return result;
}