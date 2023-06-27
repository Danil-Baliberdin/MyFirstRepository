// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] EmptyArray = new int[7];


int[] fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

int[] filledArray = fillArray(EmptyArray);

int count = 0;

for (int i = 0; i < filledArray.Length; i++)
{
if (filledArray[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {filledArray.Length} чисел, {count} четных");



