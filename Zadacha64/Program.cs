//Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии





void PrintInterval(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = m;
				end = n;
			}
			for(int i = start; i <= end; i++)
			{
				Console.Write($"{i} ");
			}
		}
		PrintInterval(1, 8);
		
		Console.WriteLine();
