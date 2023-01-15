Console.WriteLine();
int row = ReadData("Введите количество строк: "); 
int column = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(row, column, 0, 99);
Print2DArrayColor(array2D);
int minRowIndex = MinRow(array2D) + 1;
Console.WriteLine();
PrintData("Наименьшая сумма элементов в строке: "+minRowIndex);
Console.WriteLine();

//Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}

//Метод генерации массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
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
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод вывода сообщения
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//Метод нахождения строки с минимальной суммой элементов
int MinRow(int[,] matrix)
{
    int minRow = 0;
    int minRowIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minRow < sum)
        {
            minRow = sum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}
