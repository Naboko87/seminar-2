// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число number");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 7 == 0 & number % 23 == 0 )
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine("не кратно");
}
