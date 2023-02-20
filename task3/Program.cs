// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num <6 )
    {
        return true;
    }
    System.Console.WriteLine("Будни, дорогой, пошли работать:)>");
    return false;
}

   System.Console.WriteLine($" {num} УРА!Выходной!Спим до 10");


   //    if (num <>6 || num <>7)
    {
        return true;
    }
    System.Console.WriteLine("Будни, дорогой, пошли работать:)>");
    return false;
}

   System.Console.WriteLine($" {num} УРА!Выходной!Спим до 10");



