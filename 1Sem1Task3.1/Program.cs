// #3.1 Второй вариант: Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

string outDayOfWeek = string.Empty; // ""
    switch(inputNumber)
    {
        case 1: outDayOfWeek = "понедельник"; break;
        case 2: outDayOfWeek = "вторник"; break;
        case 3: outDayOfWeek = "среда"; break;
        case 4: outDayOfWeek = "четверг"; break;
        case 5: outDayOfWeek = "пятница"; break;
        case 6: outDayOfWeek = "суббота"; break;
        case 7: outDayOfWeek = "воскресенье"; break;

        default: outDayOfWeek = "Такого дня нет.";
    }
}
