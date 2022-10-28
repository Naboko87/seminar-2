// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("write number week");
int weekend_day = Convert.ToInt32(Console.ReadLine());

void ChekDay (int weekend_day){
    if (weekend_day == 6 || weekend_day == 7)
    {
        Console.WriteLine("YES Weekend day");
    }  
    else if (weekend_day < 1 || weekend_day > 7)
        {
            Console.WriteLine("mistake");
        }
    else {
        Console.WriteLine("Sorry No");
    }
}

ChekDay (weekend_day);
