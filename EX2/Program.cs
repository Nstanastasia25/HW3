// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.WriteLine("Введите число N ");
int N = Console.Read();
int i = 0; 
int result = 0;
while (i<N) 
{
    result = i*i;
    Console.Write(result);
    i = i + 1;
}