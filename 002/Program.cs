/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void Zadacha2()
{
    Random r = new Random();
    int n = r.Next(1,8);
    if (n == 1)
    {
        Console.WriteLine("Понедельник - НЕ выходной день.");
    }
    else if (n == 2)
    {
        Console.WriteLine("Вторник - НЕ выходной день.");
    }
    else if (n == 3)
    {
        Console.WriteLine("Среда - НЕ выходной день.");
    }
    else if (n == 4)
    {
        Console.WriteLine("Четверг - НЕ выходной день.");
    }
    else if (n == 5)
    {
        Console.WriteLine("Пятница - НЕ выходной день.");
    }
    else if (n == 6)
    {
        Console.WriteLine("Суббота - ВЫХОДНОЙ день!");
    }
    else if (n == 7)
    {
        Console.WriteLine("Воскресенье - ВЫХОДНОЙ день!");
    }
}
Zadacha2();