/*
14. Напишите программу, которая принимает на вход число и 
проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
string Division(int number, int div1, int div2)// Получаем ответом строку
{
    if (number % div1 == 0 & number % div2 == 0)
    {
        return "ДА";
    }
    else
    {
        return "НЕТ";
    }
}

int number = new int();
int div1 = 7;
int div2 = 23;

Console.WriteLine("введите число, ");
number = Convert.ToInt32(Console.ReadLine());


string divisionValue = Division(number, div1, div2);// получаем результат деления - строку да или нет
Console.WriteLine(divisionValue);// выводим строку, которая получилась в функции и была возвращена return'ом.