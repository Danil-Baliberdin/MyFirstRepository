/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int number = Convert.ToInt32(Console.ReadLine());

void threeDigitNumber(int x)
{
    if (x >= 1000)
    {
        while (x >= 1000)
        {
            x = x / 10;

        }
        Console.Write("3e число - ");
        Console.WriteLine(x % 10);
    }
    else if (x >= 100 && x <= 999)
    {
        Console.Write("3e число - ");
        Console.Write(x % 10);
    }
    else Console.WriteLine("3 number is empty");
}

threeDigitNumber(number);