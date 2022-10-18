// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.




Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
int secondDigit = (number-(firstDigit*100)) / 10; 

Console.WriteLine($"Полученное число {secondDigit} ");