void Test(int i, int j)
{
    bool result = (i/j == j);

    if(result==true)Console.WriteLine("Число "+i+" является квадратом числа "+j+"");
    else Console.WriteLine("Число "+i+" не является квадратом числа "+j+"");
}

int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");
Test(number1,number2);
Test(number2,number1);