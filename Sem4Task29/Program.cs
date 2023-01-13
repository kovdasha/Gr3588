//Метод ввода данных 
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод вывода данных
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArray(arr);
}

//Метод создания массива
int[] GenArray(int num1, int num2)
{
    Random rnd = new Random();
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(num1, num2);
    }
    return arr;
}

//Метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


int num1 = ReadData("Введите первое число массива: ");
int num2 = ReadData("Введите последнее число массива:");

int[] arr = GenArray(num1, num2);

PrintData("Массив:",arr);