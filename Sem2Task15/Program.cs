//Вводим значение
int number = int.Parse(Console.ReadLine()??"0");

    string outDayWeek = string.Empty;

    //Расписываю значения для каждого случая
    switch(number)
    {
        case 1: outDayWeek = "Это будний день"; break;
        case 2: outDayWeek = "Это будний день"; break;
        case 3: outDayWeek = "Это будний день"; break;
        case 4: outDayWeek = "Это будний день"; break;
        case 5: outDayWeek = "Это будний день"; break;
        case 6: outDayWeek = "Это выходной"; break;
        case 7: outDayWeek = "Это выходной"; break;
        default: outDayWeek = "Это не день недели"; break;
    }

    //Выводим данные
    Console.WriteLine(outDayWeek);
