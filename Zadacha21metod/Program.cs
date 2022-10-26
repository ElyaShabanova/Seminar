// Напишите программу, которая 
// 1.принимает на вход координаты двух точек
// 2.находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите координату y1: "); 
int y1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите координату m1: "); 
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: "); 
int x2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите координату y2: "); 
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату m2: "); 
int m2 = Convert.ToInt32(Console.ReadLine()); 

double Range(int x11, int y11, int m11, int x21, int y21, int m21) 
{
    int rangeX = x11 - x21;
    int rangeY = y11 - y21; 
    int rangeM = m11 - m21;
    double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeM * rangeM); 
    return rangeZ; 
}

double result = Range(x1,y1,m1,x2,y2,m2);
Console.Write($"А ({x1},{y1},{m1}); B ({x2},{y2},{m2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
