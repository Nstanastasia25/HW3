// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.

double  x1 = 7;
double  y1 = -5;
double  x2 = 1;
double  y2 = -1;

double  i = Convert.ToInt32(Math.Pow((x2 - x1), 2));
double  d = Convert.ToInt32(Math.Pow((y2 - y1), 2));
double  c = Convert.ToInt32(Math.Pow((i + d), 0.5));
Console.WriteLine(c);