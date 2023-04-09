//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число обозначающее день : ");

int num = int.Parse(Console.ReadLine());

if(num == 6)
{
    Console.Write("Это выходной");
    return;
}
if(num == 7)
{
    Console.Write("Это выходной");
    return;
}
else
{
    Console.Write("Это будний день");
}

