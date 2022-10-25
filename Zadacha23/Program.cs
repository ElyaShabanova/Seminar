// Напишите программу, которая принимает 
// 1. на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите данные:"); 
int n = Convert.ToInt32(Console.ReadLine()); 
int count=1; 
while (count <=n) 
{
    int quad = count*count*count; 
    Console.WriteLine($"{count}  ->  {quad}");  
    count++;  
}