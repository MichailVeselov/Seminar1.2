//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите Число ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100)
   Console.WriteLine("Такого числа нет"); 
while (number >= 100)
{
  number = number % 10;
  Console.WriteLine(number);
}

Console.WriteLine(number % 10);

