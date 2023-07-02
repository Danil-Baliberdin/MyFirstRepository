/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int inputNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

int size = inputNum("Введите количество чисел которые хотите записать: ");

int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = inputNum($"Введите {i+1}e число: ");
}
int count = 0;
int moreNull(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int answer = moreNull(array);
Console.Write($"Количество цисел больше 0 = {answer}");
