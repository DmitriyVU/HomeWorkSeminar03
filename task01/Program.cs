/*Напишите программу, которая принимает 
 на вход пятизначное число и проверяет, является ли 
 оно палиндромом.

 14212 -> нет
 23432 -> да
 12821 -> да */
Console.Clear();

Console.Write("Введите любое пятизначное число -");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    num *= -1;
}
if (num >= 10000 && num < 100000)
{
    int A = num / 10000;
    int B = num / 1000 % 10;
    int C = num % 100 / 10;
    int D = num % 10;
    if (A == D && B == C)
    {
        Console.WriteLine($"{num} - да! палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - НЕ палиндром!");
    }
}
else
{
    Console.WriteLine($"{num} - НЕ пятизначное!?!");
}