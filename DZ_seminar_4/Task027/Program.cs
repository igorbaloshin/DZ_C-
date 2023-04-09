// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.Clear();
Console.WriteLine("Введите число : ");
int K = int.Parse(Console.ReadLine());
//-----------------------------------------
int CountNumbers(int n)
{
    int count = 0;
    if(n < 0)
       n *= (-1);
    while(n > 0)
    {
        n /= 10; 
        count++;
    }
    return count;
} 
//----------------------------------------
void FillArray(int[] array, int K) // K число разлагаемое на массив
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = (K % Convert.ToInt32(Math.Pow(10, length - index)) - K % Convert.ToInt32(Math.Pow(10, (length - index - 1)))) / (Convert.ToInt32(Math.Pow(10, length - index - 1)));
        index++;
    }
}
//-------------------------------------------

int Sum(int[] array)
{
    int length = array.Length;
    int index = 0;
    int sum = 0;
    while(index <= length -1)
    {
        sum = sum + array[index];
        index++; 
    }
    return sum;
}
//-------------------------------------------
int N = CountNumbers(K);

int[] massiv = new int[N];

FillArray(massiv, K);

int sum = Sum(massiv);

Console.WriteLine($"Сумма цифр числа = {sum}");

