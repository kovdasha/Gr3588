double[] array = GenArray(4, 13, 15);
PrintArray(array);
double res = MinMax(array);
PrintData(res);

//Метод генерации массива
double[] GenArray(int len, double minValue, double maxValue) 
 {
     double[] arr = new double[len];
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = new Random().NextDouble() * (maxValue - minValue) + minValue; 
     }
     return arr;
 }

//Метод вывода массива
 void PrintArray(double[] arr)
 {
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1]);
 }

//Метод вывода результата
 void PrintData(double res)
 {
     Console.WriteLine(res);
 }

//Метод нахождения разницы меду max и min элементами
double MinMax(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    res = max-min;
    return res;
}