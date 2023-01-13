int number = ReadData("Введите общее количество чисел: ");
int result = CountPositiveNumber(number);
PrintData("Количество чисел больше нуля: ", result);

//Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода данных
void PrintData(string result, int value)
{
    Console.WriteLine(result + value);
}

//Метод подсчёта положительных чисел
int CountPositiveNumber(int number)
{
    int result = 0;
    while(number > 0)
    {
        if (ReadData("Введите число: ") > 0) result++;
        number = number - 1;
    }
    return result;
}
