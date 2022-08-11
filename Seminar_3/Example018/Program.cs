/*

Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).

*/
string getCoordinatesFromQuarter (int quarter)
{ 
    string availableQuarter = "Значения отсутсвуют, попробуйте другое значение";
    if (quarter == 1)
    {
        availableQuarter =  "x>0 and y>0";
    }
    else if (quarter == 2)
    {
        availableQuarter =  "x<0 and y>0";
    }
    else if (quarter == 3)
    {
        availableQuarter =  "x<0 and y<0";
    }
    else if (quarter == 4)
    {
        availableQuarter =  "x>0 and y<0";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ($"возможен подбор значений для одной из 4-х четвертей, а вы выбрали {quarter}");
        Console.ResetColor();
    }
    return availableQuarter;
}
Console.WriteLine("Введите Четверть:");
int quarter = Convert.ToInt32(Console.ReadLine());
string answer = getCoordinatesFromQuarter(quarter);
Console.WriteLine($"Возможные значения для выбранной четверти {answer}");