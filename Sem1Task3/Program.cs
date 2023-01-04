//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)

{
    // // Создаём массив с днями неделями
    // string [] dayWeek = new string [7];
    // dayWeek[0] = "Понедельник";
    // dayWeek[1] = "Вторник";
    // dayWeek[2] = "Среда";
    // dayWeek[3] = "Четверг";
    // dayWeek[4] = "Пятница";
    // dayWeek[5] = "Суббота";
    // dayWeek[6] = "Воскресенье";

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    // //Находим название дня недели по введенному номеру
    // string outDayWeek = dayWeek[inputNumber-1];

    string outDayWeek = string.Empty;

    switch(inputNumber)
    {
        case 1: outDayWeek = "Понедельник"; break;
        case 2: outDayWeek = "Вторник"; break;
        case 3: outDayWeek = "Среда"; break;
        case 4: outDayWeek = "Четверг"; break;
        case 5: outDayWeek = "Пятница"; break;
        case 6: outDayWeek = "Суббота"; break;
        case 7: outDayWeek = "Воскресенье"; break;
        default: outDayWeek = "Это не день недели"; break;
    }

    //Выводим данные
    Console.WriteLine(outDayWeek);
}

// Также можно обратиться к нашей системе и спросить у неё день недели