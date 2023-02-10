/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
String? strNumber = Console.ReadLine();
int number=Convert.ToInt32(strNumber);
int result;

if ((number/ 100>0) && (number / 1000==0))

{
  result=number/10 % 10;
  Console.WriteLine(result);
}
else 
Console.WriteLine("НЕ является трехзначным!");