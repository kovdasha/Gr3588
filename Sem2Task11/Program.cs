//Создаём рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем случайное трехзначное число
int number = numberSintezator.Next(100,1000);
Console.WriteLine (number);

//Разбиваем трехзначное число на отдельные числа
//int firstNumber = number/100;
//int secondNumber = number%10;
//int result = firstNumber*10 + secondNumber;

int result = (number/100)*10 + number%10;

//Выводим данные в консоль
    Console.WriteLine(result);