// 58
// сделать 2 матрицы и перемножить их
int inputNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int str = inputNum("Введите количество строк: ");
int col = inputNum("Введте количсетво столбцов: ");

int[,] CreateArray(int strin, int colu)
{
    int[,] array = new int[strin, colu];
    return array;
}

int[,] array1 = CreateArray(str, col);
int[,] array2 = CreateArray(str, col);
int[,] resultArray = new int[str, col];

void FillArray(int[,] array, int str, int col)
{
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

FillArray(array1, str, col);
FillArray(array2, str, col);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

MultiplyMatrix(array1, array2, resultArray);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; "); 
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}
PrintArray(array1);
PrintArray(array2);
PrintArray(resultArray);
