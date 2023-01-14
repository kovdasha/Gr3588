﻿//Найтb элементы, у которых оба индекса чётные и заменить их на квадраты
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
Update2DArray(arr2D);
Print2DArrayColor(arr2D);

//Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерации масиива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 01; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
        array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Green,ConsoleColor.Blue,ConsoleColor.Cyan,
                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};                                 

//Метод вывода цветного массива
void Print2DArrayColor(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод нахождения элементов с чётными индексами и замены на их квадраты
void Update2DArray(int[,] arr)
{
    for (int i = 01; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}