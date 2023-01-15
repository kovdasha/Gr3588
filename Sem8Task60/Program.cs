int x = ReadData("Введите значение X: ");                           
int y = ReadData("Введите взначение Y: "); 
int z = ReadData("Введите значение Z: ");
int[,,] array3D = Fill3DArray(x, y, z);                
Print3DArrayColor(array3D);  

//Метод ввода данных
int ReadData(string message)
{
    Console.WriteLine(message);
    int inputNum = int.Parse(Console.ReadLine()??"0");
    return inputNum;
}

//Метод генерации случайных двузначных чисел
int GenNum(List<int> num)
{
    int index = new System.Random().Next(0,num.Count);
    int result = num[index];
    num.RemoveAt(index);
    return result;
}

//Метод заполнения массива случайными двузначными числами
int[,,] Fill3DArray( int countRow, int countColumn, int countList)
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < 90; i++)
    {
        numbers.Add(10+i);
    }
    int[,,] array3D = new int[countRow, countColumn, countList];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int l = 0; l < countList; l++)
            {
                array3D[i, j, l] = GenNum(numbers);
            }
        }
    }
    return array3D;
}

//Метод печати цветного массива
void Print3DArrayColor(int[,,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Green,ConsoleColor.Blue,ConsoleColor.Cyan,
                            ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                            ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                            ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int l = 0; l < matrix.GetLength(1); l++)
            {
                Console.ForegroundColor = col[matrix[j, l, i] % 15];
                Console.Write(matrix[j, l, i] +$"({j},{l},{i}) ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
