/*Напишите программу
1. принимает на вход число  
2. выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigit(int numDigit)
{
    int count = 0;
    while (numDigit > 0)
    {
        count = count + numDigit % 10;
        numDigit = numDigit / 10;
    }
    return count;
}
int sumDigit = SumDigit(num);
Console.WriteLine($"Количество цифр в числе = {sumDigit}");
