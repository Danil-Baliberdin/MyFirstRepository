// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] EmptyArray = new int[7];


int[] fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
    return array;
}

int[] filledArray = fillArray(EmptyArray);

int sum = 0;

for (int i = 0; i < filledArray.Length; i++)
{
if (filledArray[i] % 2 == 0)
sum = sum + filledArray[i];
}
Console.WriteLine($" сумма четных элементов = {sum} ");