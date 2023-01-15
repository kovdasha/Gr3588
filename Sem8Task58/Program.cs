Console.WriteLine();
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] matrix1 = Fill2DArray(row, column, 1, 99);
int[,] matrix2 = Fill2DArray(row, column, 1, 99);
Console.WriteLine();
PrintData("Матрица №1:");
Print2DArrayColor(matrix1);
PrintData("Матрица№2:");
Print2DArrayColor(matrix2);
int[,] productMatrix = ProductMatrix(matrix1, matrix2);
Console.WriteLine();
PrintData("Произведение двух матриц:");
Console.WriteLine();
Print2DArrayColor(productMatrix);

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

//Метод вывода цветного массива
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

//Метод перемножения матриц
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int sum = 0;
    int[,] outArr = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                sum += matrix1[i, j] * matrix2[j, k]; 
            }
            outArr[i, k] = sum;
            sum = 0;
        }
    }
    return outArr;
}