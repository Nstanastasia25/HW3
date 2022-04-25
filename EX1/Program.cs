// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 0 1 2 3 4
Console.WriteLine("Введите пятизначное число ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(fiveDigitNumber);
if (stringNumber[0]==stringNumber[4] && stringNumber[1]==stringNumber[3])
{
    Console.WriteLine("Данное число является палиндромом");
}
else Console.WriteLine("Данное число не является палиндромом");