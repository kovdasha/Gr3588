//Создаём рандомайзер
System.Random numberSintezator = new System.Random();

//Вариант 1
//Получаем новое случайное число
int number = numberSintezator.Next(10,100);
   
//Выводим данные в консоль
Console.WriteLine(number);

//Получаем первое и второе число по отдельности
int firstNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
if(firstNumber>secondNumber)
{
    //Выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine(secondNumber);
}

//Вариант 2
//Получаем двузначное число
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

//Разбиваем двузначное на отдельные числа
firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

//Сравниваем их между собой
int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

//Выводим ваддные в консоль
Console.WriteLine(resultNumber);

//Вариант 3
//Использование в решение массив