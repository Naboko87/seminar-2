// See https://aka.ms/new-console-template for more information
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("write number");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length > 2)
{
    Console.WriteLine("Three number : " + number_text[2]);
    
}else
    {
        Console.WriteLine("no three number");
    }