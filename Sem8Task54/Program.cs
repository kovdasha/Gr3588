int row = ReadData("Введите количество строк: ");      
int column = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(row, column, 1, 99);
Console.WriteLine();
Console.WriteLine();
Print2DArray(array2D);
Sort2DArray(array2D);
Console.WriteLine();
PrintData("Упорядоченный по убыванию массив:");
Console.WriteLine();
Print2DArray(array2D);
Console.WriteLine();

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

// Метод выводит на печать сообщение
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//Метод вывода печати массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Метод выполняет сортировки строк массива
int[,] Sort2DArray(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        int[] sortRow = BubbleSort(row);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = sortRow[j];
        }
    }
    return matrix;
}

//Метод сортировки пузырьком
int[] BubbleSort(int[] arr)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
            int Temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = Temp;
            }
        }
    }
    return arr;
}