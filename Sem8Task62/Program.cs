int size = ReadData("Введите размерность матрицы: ");    
int[,] arr2D = FillSpiral2DArray(size); 
Print2DArray(arr2D);                  

//Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерации массива по спирали
int[,] FillSpiral2DArray(int n)
{
    int[,] outArray = new int[n, n];
    int iBegin = 0, iEnd = 0, jBegin = 0, jEnd = 0;
    int i = 0, j = 0, k = 1;
    while (k <= n * n)
    {
        outArray[i, j] = k;
        if (i == iBegin && j < n - jEnd - 1)
            j++;
        else if (j == n - jEnd - 1 && i < n - iEnd - 1)
            i++;
        else if (i == n - iEnd - 1 && j > jBegin)
            j--;
        else
            i--;
        if ((i == iBegin + 1) && (j == jBegin) && (jBegin != n - jEnd - 1))
        {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;
        }
        k++;
    }
    return outArray;
}

//Метод вывода массива в печать
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

