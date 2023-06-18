//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int number = Convert.ToInt32(Console.ReadLine());

int cube(int x)
{
    return x * x * x;
}


for (int i = 0; i < number; i++)
{
    Console.Write(cube(i + 1));
}




