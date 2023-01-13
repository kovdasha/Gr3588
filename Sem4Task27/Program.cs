//Метод ввода данных 
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
  }

//Метод вывода данных
void PrintResult(string sum)
{
   Console.WriteLine(sum);
}

//Метод вычисления сумм цифр
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum +=num%10;
        num = num/10;
    }
    return sum;
}

int num = ReadData("Введите число: ");
int sum = SumDigits(num);
PrintResult("Сумма цифр в числе = " +sum);
