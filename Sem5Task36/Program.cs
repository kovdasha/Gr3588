int[] array = GenArray(1, 100, 1000);
PrintArray(array);
Console.WriteLine();
int result = SummaOdd(array);
PrintData("Сумма элементов, стоящих на нечётных позициях: ", result);

// Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

//Метод вывода массива
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод вывода данных
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод подсчёта суммы элементов на нечётных позициях
int SummaOdd(int[] arr)
{
    int result = 0;
    for (int i=1; i<arr.Length; i+=2)
    {
        result = result + arr[i];       
    }
    return result;
}

    