//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = Convert.ToInt32(Console.ReadLine());
int x;
if (number >= 100 && number <= 999)
{
x = number;
int secondNumber(int num)
{
int result;
result = (x % 100) / 10;
return result;
}
Console.Write("second number is ");
Console.Write(secondNumber(x));
}
else
Console.WriteLine("вы ввели неправильное число, надо 3-значное ");