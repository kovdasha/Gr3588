int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] array2D = GenArray(row, column, 1, 99);
Print2DArrayColor(array2D);
int[] avg = AverageColumn(array2D);
PrintData("Строка среднего арифметического: ");
Print1DArr(avg);

//Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}

//Метод генерации массива
int[,] GenArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
        array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

//Метод печати цветного массива
void Print2DArrayColor(int[,] matrix)
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
        Console.Write(matrix[i, j]+"     ".Substring(matrix[i, j].ToString().Length));
        Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

//Метод нахождения среднего арифметического
int[] AverageColumn(int[,] array2D)
{
    int[] avr = new int[array2D.GetLength(1)];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            avr[j] += array2D[i, j];
        }
        avr[j] = avr[j] / array2D.GetLength(0);
    }

    return avr;
}

//Метод вывода данных
void PrintData(string msg)
{
Console.WriteLine(msg);
}

//Метод, выводящий на печать массив
void Print1DArr(int[] avg)
{
    for (int i = 0; i < avg.Length - 1; i++)
    {
        Console.Write(avg[i] + "   ");
    }
    Console.WriteLine(avg[avg.Length - 1]);
}