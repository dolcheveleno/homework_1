/*
Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
void Zadacha1()
{
    Random rand = new Random();
    int n = rand.Next(10,1000);
    Console.WriteLine(n);
    if (n<100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
   else if (n<1000)
   {
        int digit = n%10;
        Console.WriteLine($"Третья цифра: {digit}");
    }
}
Zadacha1();

