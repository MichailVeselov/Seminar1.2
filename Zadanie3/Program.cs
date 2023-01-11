// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру ");
int Figure = Convert.ToInt32(Console.ReadLine());
if (Figure % 7 >= 5)
Console.WriteLine("Выходной");
else 
Console.WriteLine("Будни");



