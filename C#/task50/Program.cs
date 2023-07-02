/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int InputNum(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int str = InputNum("Введите номер строки : ");
int column = InputNum("Введите номер столбца : ");

int[,] array = new int[7, 7];
int sizeStr = 7;
int sizeCol = 7;

void FillArray(int[,] array, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = (int)Math.Round((new Random().NextDouble() - 0.5) * 100, 2);
        }
    }
}

FillArray(array, 7, 7);
void PrintArray(int[,] array, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine();
    }
}

PrintArray(array, 7, 7);

void FoundNum(int[,] array, int numStr, int numCol)
{
    if (numStr > sizeStr && numCol > sizeCol)
    {
        Console.WriteLine("Number is not exists((");
    }
    else Console.WriteLine($"Число под искомыми индексами = {array[numStr - 1, numCol - 1]}");
}

FoundNum(array, str, column);