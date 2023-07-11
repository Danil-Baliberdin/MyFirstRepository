// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// с помощью рекрсии вывести на экран числа от N до 1.


int InputNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int N = InputNum("Введите число: ");

void PrintNums(int i)
{
    if (i == 1)
    {
        Console.Write(i + ". ");
        return;
    }
    Console.Write(i + ", ");
    i--;
    PrintNums(i);
}
PrintNums(N);