int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
int result = AkkermannFunction(numberM, numberN);
PrintResult("Функция Аккермана равна: " + result);

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

///Метод вычисления функции Аккермана:
int AkkermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkkermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermannFunction(numberM - 1, AkkermannFunction(numberM, numberN - 1));
    return AkkermannFunction(numberM, numberN);
}
