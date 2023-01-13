//Подключение больших чисел
using System.Numerics;

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

//Метод вычесления факториала
BigInteger CalculateFactorial(int num)
{    
    BigInteger count = 1;
    for(int i=1;i<=num;i++)
    {
       count *= i;
    }
    return count;
}

int number = ReadData("Введите число А:");
BigInteger length = CalculateFactorial(number);
PrintData("Факториал числа А равен: " + length);