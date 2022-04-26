// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double x1 = 3;
double y1 = 6;
double z1 = 8;

double x2 = 2;
double y2 = 1;
double z2 = -7;


double i = Convert.ToInt32(Math.Pow((x2 - x1), 2));
double d = Convert.ToInt32(Math.Pow((y2 - y1), 2));
double f = Convert.ToInt32(Math.Pow((z2 - z1), 2));
double c = Convert.ToInt32(Math.Pow((i + d + f), 0.5));
Console.WriteLine(c);
