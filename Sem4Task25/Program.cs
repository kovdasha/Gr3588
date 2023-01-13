//Метод ввода данных 
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
  }

// Метод вывода данных
void PrintResult(string res)
{
   Console.WriteLine(res);
}

//Метод вычисления степени
int CalculateDegree(int numA, int numB)
{
    int res = (int)Math.Pow(numA, numB);
    return res;
}


int numA = ReadData("Введите первое число: ");
int numB = ReadData("Введите второе число: ");
int res = CalculateDegree(numA, numB);

PrintResult($"Число {numA} в степени {numB} = {res}");