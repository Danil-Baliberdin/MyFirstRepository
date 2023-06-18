/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int number = Convert.ToInt32(Console.ReadLine());
String day(int x)
{
     if (x == 1)
        return "work";
    else if (x == 2)
        return "work";
    else if (x == 3)
        return "work";
    else if (x == 4)
        return "work";
    else if (x == 5)
        return "work";
    else if (x == 6)
        return "weekend";
    else if (x == 7)
        return "weekend";
    else
    return "вы ввели неправильное число";
}

Console.WriteLine(day(number));