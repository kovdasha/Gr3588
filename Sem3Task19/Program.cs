﻿// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат пользователю
void PrintData(string msg, bool res)
{
    if (res == true) Console.WriteLine(msg + "Да");
    else Console.WriteLine(msg + "Нет");
}

//Создаем коллекцию

Dictionary<int, int> FourDigitPalind = new Dictionary<int, int>();

//Заполняем коллекцию
int key = 0;
for (int i = 1; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {

        int value = i + 10 * j + 100 * j + 1000 * i;
        FourDigitPalind.Add(key++, value);
    }
}

//Метод проверяет, является ли введенное число палиндромом
bool PalindromTest(int num)

{
    bool result = false;
    // int firstPartNumber = 0;
    // int secondPartNumber = 0;
    if (num > 9999 && num < 100000)

    {
        // firstPartNumber = num / 1000;
        // secondPartNumber = num % 100;
        // num = (num / 1000) * 100 + num % 100;
        if (FourDigitPalind.ContainsValue((num / 1000) * 100 + num % 100)) result=true;
        
    }

    else Console.WriteLine("Вы ввели не пятизначное число");
    return result;
}

int number = ReadData("Введите пятизначное число: ");
PrintData("Введенное число является полиндромом? ", PalindromTest(number));
