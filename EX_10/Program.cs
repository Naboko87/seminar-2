// See https://aka.ms/new-console-template for more information
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("write number");
int number_1 = Convert.ToInt32(Console.ReadLine());
string array_number = number_1.ToString();
int index = 1;
for (int i = 0; i < array_number.Length; i++)
{
    if (i == index)
    {
        Console.WriteLine("second number");
        Console.WriteLine(array_number[i]);
    } 
}
