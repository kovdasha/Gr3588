﻿// Метод читает данные от пользователя
int ReadData(string msg)

{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит данные пользователю
void PrintData(string msg, string res)

{
    Console.WriteLine(msg + res);
}

//Метод на выходе выдает строку со степенями чисел
string LineBilder(int num, int pow)
{
    string result = string.Empty;
    for (int i = 1; i < num; i++)

    {
        result = result + Math.Pow(i, pow) + " ";
    }

    result = result + Math.Pow(num, pow);
    return result;
}

int number = ReadData("Введите число: ");
PrintData("", LineBilder(number, 1));
PrintData("", LineBilder(number, 3));

