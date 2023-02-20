// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Usernum(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Weekd(int numday)
{
    if (numday >5)
    {
        return true;
    }

    return false;
}

bool Validate(int day)
  {

    if (day >0 && day <=7)
{
     return true;
}
    System.Console.WriteLine("Ват?Попробуй еще раз");
    return false;
  } 

int weekday=Usernum("Введите номер дня недели ");
if (Validate(weekday))
 {
    if (Weekd(weekday))
    {
        System.Console.WriteLine($" {weekday} это выходной!Спим до 10 :))))))");
    }
    else
    {
        System.Console.WriteLine($" {weekday} это будни :( Придется поработать.");
    }
 }

  


