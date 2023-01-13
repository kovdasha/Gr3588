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

//Метод решения с помощью логарифма
int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

//Метод решения с помощью строки
int VariantString(int num)
{
    int count = num.ToString().Length;
    return count;
}

//Метод решения в лоб
int VariantSimple(int num)
{
    int count = 0;
    while (num>0)
    {
        count++;
        num=num/10;
    }
    return count;
}


int number = ReadData("Введите число А:");

DateTime d1 = DateTime .Now;
int length1 = VariantLog(number);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime .Now;
int length2 = VariantString(number);
Console.WriteLine(DateTime.Now-d2);

DateTime d3 = DateTime .Now;
int length3 = VariantSimple(number);
Console.WriteLine(DateTime.Now-d3);

PrintData("Количество цифр в числе равно: " + length1);
PrintData("Количество цифр в числе равно: " + length2);
PrintData("Количество цифр в числе равно: " + length3);
