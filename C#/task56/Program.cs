// // задать двумерный массив и найти сторку с наименьей суммой элементов

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


int[] HelpArray = new int[4];
void LowString(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        int count = 0;
        for (int j = 0; j < 4; j++)
        {
            count = count + array[i, j];
        }
        HelpArray[i] = count;
    }

}
LowString(FilledArray);

for (int j = 0; j < 4; j++)
{
    Console.WriteLine($"Сумма элементов {j + 1} строки = {HelpArray[j]}");
}

void answer(int[] array)
{
    int minStr = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] <= minStr)
        {
            minStr = array[i];
        }
    }
    int answer = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minStr == array[i])
        {
            answer = i;
        }
    }

    Console.WriteLine($"Строка c минимальной суммой элементов - {answer + 1}");
}
answer(HelpArray);
