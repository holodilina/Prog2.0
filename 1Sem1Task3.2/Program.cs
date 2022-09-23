// #3.2 Третий вариант: Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

string outDayOfWeek = string.Empty; // ""
    
    outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));

    Console.WriteLine(outDayOfWeek);

}
