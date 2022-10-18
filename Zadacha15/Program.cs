// Напишите программу, которая принимает на
// 1.вход цифру, обозначающую день недели
// 2.проверяет является ли этот день выходным.


Console.WriteLine("Введите число от 1 по 7: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number == 6 || number ==7) 
{
    Console.WriteLine($"Выходной день ");
}

else 
{
    Console.WriteLine($"Не выходной день "); 
}
