// Программа, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространтсве

double Distance(double x1, double y1, double x2, double y2)
{
    double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return dist;
}

Console.WriteLine(Distance(3,6,2,1));
Console.WriteLine(Distance(7,-5,1,-1));