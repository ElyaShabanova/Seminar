// Напишите программу, которая 
// 1.принимает на вход координаты двух точек
// 2.находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А:"); 
Console.Write("Х: "); 
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Y: "); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("M: ");
int m1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите координаты точки B:"); 
Console.Write("Х: "); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Y: ");   
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("M: ");   
int m2 = Convert.ToInt32(Console.ReadLine()); 

double GetDist(int xc1, int xc2, int yc1, int yc2, int mc1, int mc2)  
{
    double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(m1-m2)*(m1-m2)); 
    d = Math.Round(d, 2, MidpointRounding.ToZero); 
    return d;
}

double res = GetDist(x1, x2, y1, y2, m1, m2); 
Console.WriteLine(res);             