/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int inputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int str = inputNum("Введите количество строк в вашем массиве: ");
int column = inputNum("Введите количество столбцов в вашем массиве: ");

double[,] matrix = new double[str, column];

void FillMatrix(double[,] array,int strin, int colu) {
    for(int i =0; i<strin; i++){
        for(int j =0; j<colu; j++){
            array[i,j] = Math.Round((new Random().NextDouble() -0.5 ) * 10, 2);
        }
    }
}

FillMatrix(matrix, str, column);

void PrintArray(double[,] array, int strin, int colu){
    for(int i =0; i<strin; i++){
        for(int j =0; j<colu; j++){
            Console.Write($" {array[i,j]} ; ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix, str, column);
