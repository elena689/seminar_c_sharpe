﻿int day = new int ();

while (true)
{
    Console.WriteLine("Введите число дня недели от 1 до 7:");
    day = Convert.ToInt32(Console.ReadLine());
    switch (day)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресение");
            break;
        default:
            Console.WriteLine("Нет дня недели для этого числа");
            break;
    }
}
