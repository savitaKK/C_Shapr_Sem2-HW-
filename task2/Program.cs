// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int number)
{
if (number>99)
    {
        return true;
    }
    System.Console.WriteLine("Тут нет третьей цифры :( Попробуй еще разок, дружок ;)");
    return false;
}
    

int trDigit(int num)
{
while (num >999)
{
    num/=10;
}
return num % 10;

}
 
 int number = Prompt ("Введите число"); 
 if (Validate(number))
 {
    System.Console.WriteLine($"Третья цифра числа {number} это {trDigit(number)}");
 }
