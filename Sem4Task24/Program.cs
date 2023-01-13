//Напишите программу, которая принимает число А, а выдаёт сумму чисел от 1 до А
//Первый метод в лоб, а второй с помощью формулы

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

//Метод накопления значений
int VariantSumSimple(int numA)
{
    int sumOfNumber = 0;
    for (int i=1; i<=numA;i++)
    {
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

//Метод решения с помощью формулы Гауса
int VariantSumGause(int numA)
{
    int sumOfNumbers=0;
    sumOfNumbers= ((1+numA)*numA)/2;
    return sumOfNumbers;
}

//Запрос числа у пользователя
int numderA = ReadData("Введите число А:");

//Запрашиваем результат суммы со временем
DateTime d1 = DateTime .Now;
int res1 = VariantSumSimple(numderA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numderA);
Console.WriteLine(DateTime.Now-d2);

//Вывод результата
PrintData("Сумма чисел от 1 до А равна (простой метод): " + res1);
PrintData("Сумма чисел от 1 до А равна (метод Гауса): " + res2); 


//Различные методы нужны для эффективности и скорости отклика










