/* Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
NameArray(number);
PrintArray(number);
int count = 0;

for (int a = 1; a < number.Length; a+=2)
{
    count = count + number[a];
}
Console.WriteLine($"Cумма элементов на нечётных позициях = {count}");


void NameArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }

    Console.WriteLine();
}
