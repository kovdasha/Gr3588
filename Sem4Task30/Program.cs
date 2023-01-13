//Метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод вывода данных
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArray(arr);
}

//Метод генерации массива
int[] GenArray(int len)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

//Метод ввыода массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int arrLen = ReadData("Введите длину массива: ");

int[] arr = GenArray(arrLen);

PrintData("Сгененрированный массив: ",arr);
