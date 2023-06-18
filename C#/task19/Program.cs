/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
int number = Convert.ToInt32(Console.ReadLine());
void palindrome(int x){
if (x/10000==x%10 && (x/1000)%10 == (x%100)/10){
    Console.Write("palindrome");
}
else Console.Write("noPalindrome");
}
palindrome(number);