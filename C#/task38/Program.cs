// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] emptyArray = new double[15];

double[] fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;

}

double[] filledArray = fillArray(emptyArray);

double max = 0;
for (int i = 0; i < filledArray.Length; i++)
{
    if (filledArray[i] > max)
    {
        max = filledArray[i];
    }
}

double min = 1.7976931348623158 * 10000;
for (int i = 0; i < filledArray.Length; i++)
{
    if (filledArray[i] < min)
    {
        min = filledArray[i];
    }
}

Console.WriteLine(max - min);
