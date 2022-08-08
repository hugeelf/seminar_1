/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли  второе число кратным первому. Если число 2  не кратно числу 1, 
то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
int Division (int firstNumber, int secondNumber){
    int result = secondNumber%firstNumber;
    return result;
}


int firstNumber = new int();
int secondNumber = new int();
Console.WriteLine("введите первое число, ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число, ");
secondNumber = Convert.ToInt32(Console.ReadLine());

int divisionValue = Division(firstNumber, secondNumber);// получаем результат деления.
if(divisionValue == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine(divisionValue);
}
