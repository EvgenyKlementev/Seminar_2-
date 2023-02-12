/* Напишите программу, которая принимает на вход цифру, обозначающую день 
недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

int Saturday=6;
int Sunday=7;

if(number==Saturday||number==Sunday)
Console.WriteLine("Поздравляю, у Вас выходной!");
else Console.WriteLine("Идем на работу!");