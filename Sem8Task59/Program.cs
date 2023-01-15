//Удалите строку и столбец, на пересечении которых расположен наименьший элемент массива
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");  
int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColor(arr2D);
Console.WriteLine();

(int x, int y) min = SearchMinElem(arr2D);
int[,] outArray=Convert2DArray(arr2D, min.x, min.y);
Print2DArrayColor(outArray);

//Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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
            Console.Write(" " + matrix[i, j] + "    ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();                                                   // Устанавливает исходный цвет
        }
        Console.WriteLine();
    }
}

//Метод поиска минимального элемента 
(int x, int y) SearchMinElem(int[,] arr)
{
    int row=0, colomn = 0;
    //Инициализируем максимальным элементом
    int min = int.MaxValue;                 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                row = i;
                colomn = j;
            }
        }
    }
    return (row, colomn);
}

//Метод удаления строки и столбеца, на пересечении которых находится минимальный элемент 
int[,] Convert2DArray(int[,] arr, int x, int y)
{
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0, m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != x && j != y)
            {
                outArr[k,m] = arr[i, j];
            }
            if (j != y) m++;
            
        }
        if (i != x) k++;
    }
    return outArr;
}