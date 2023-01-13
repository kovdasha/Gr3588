 int[] array = GenArray(15, 100, 999);
 PrintArray(array);
 int res = CountEven(array);
 PrintData(res);

//Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue) 
 {
     int[] arr = new int[len];
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = new Random().Next(minValue, maxValue + 1);
     }
     return arr;
 }

//Метод ввывода массива
 void PrintArray(int[] arr)
 {
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1]);
 }

//Метод вывода данных
 void PrintData(int res)
 {
     Console.WriteLine(res);
 }

//Метод подсчёта чётных элементов в массиве
 int CountEven(int[] arr) 
 {
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        res++;
    }
    return res;
 }