/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] array = new int[4, 4];

void FillMatrix(int[,] array, int strin, int colu)
{
    for (int i = 0; i < strin; i++)
    {
        for (int j = 0; j < colu; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array, int strin, int colu)
{
    for (int i = 0; i < strin; i++)
    {
        for (int j = 0; j < colu; j++)
        {
            Console.Write($" {array[i, j]} ; ");
        }
        Console.WriteLine();
    }
}

void MidNum(int[,] array, int str, int col)
{



    for (int i = 0; i < str; i++)
    {
        double answer = 0;
        for (int j = 0; j < col; j++)
        {
            answer = answer + array[j, i];
        }
        Console.WriteLine($"Среднеарифметическое столбца номер {i + 1} = {Math.Round(answer / col, 2)}");
    }
}



FillMatrix(array, 4, 4);
PrintArray(array, 4, 4);
MidNum(array, 4, 4);


