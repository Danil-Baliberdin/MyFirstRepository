// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i + 1} число:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArray()
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}. ");
        }

        else Console.Write($"{array[i]}, ");
    }
}

PrintArray();