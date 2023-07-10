// // задать двумрный масив и упорядочить каждую строку по убыванию

int[,] array = new int[4, 4];

int[,] fillArray(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] FilledArray = fillArray(array);

void answerArray(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                int tmp = array[i, j + 1];
                array[i, j + 1] = array[i, j];
                array[i, j] = tmp;

            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
answerArray(FilledArray);
PrintArray(FilledArray);
