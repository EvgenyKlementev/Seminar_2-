/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/



Console.WriteLine("Введите число: ");

int number=Convert.ToInt32(Console.ReadLine());

int A = number;
if (number<100)

{
  Console.WriteLine($"НЕТ третьей цифры!!!!");
}

while ( A >1000)
{
    A /= 10;
}
int result = A % 10;
Console.WriteLine($"Третья цифра{number}--> {result}");







