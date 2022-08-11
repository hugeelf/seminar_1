/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
int getQuarterFromCoordinate (int x, int y)
{
    int result = 0;
    if(x>0 && y>0)
    {
        result = 1;
    }
    else if(x<0 && y>0)
    {
        result = 2;
    }
     else if (x<0 && y<0)
    {
        result = 3;
    }
    else if(x>0 && y<0)
    {
        result = 4;
    }
    else 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ($"X и Y не должны быть равны 0, а вы ввели {x} {y}");
    }
    return result;
}
int x = 0;
int y = 0;
Console.WriteLine("Введите X:");
x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
y=Convert.ToInt32(Console.ReadLine());
int quoter = getQuarterFromCoordinate(x,y);
Console.WriteLine($"Для координаты {x}:{y} находится в {quoter} четверти");