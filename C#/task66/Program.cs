// найти сумму элементов от m до n с помощью рекурсии

int InputNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int M = InputNum("Введите число от которого начать : ");
int N = InputNum("Введите число от которым закончить : ");

int SumNum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + SumNum(m + 1, n);

}
int answer = SumNum(M, N);
Console.WriteLine(answer);
