// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

if(N < 100)
{
    Console.WriteLine("Третьей чифры нет");
}
else
{
    Console.WriteLine((N % 1000 - N % 100) / 100);
}

