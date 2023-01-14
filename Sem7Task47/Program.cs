﻿int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
double[,] arr2D = GenArray(row, column, 10, 99);
Print2DArrayColor(arr2D);

//Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод генерации массива
double[,] GenArray(int countRow, int countColumn, double topBorder, double downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
        array2D[i, j] = Math.Round((rand.NextDouble()*(topBorder-downBorder)+downBorder),2);
        }
    }
    return array2D;
}

//Метод печати цветного массива
void Print2DArrayColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Green,ConsoleColor.Blue,ConsoleColor.Cyan,
                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};                          
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.ForegroundColor = col[new System.Random().Next(0,16)];
        Console.Write(matrix[i, j]+"       ".Substring(matrix[i, j].ToString().Length));
        Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}