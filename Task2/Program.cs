/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine()!);

if (a > 100000)
{
    Console.WriteLine($"Число слишком большое");
}
else
{
    if (a < 100)
    {
        Console.WriteLine("Нету 3 цифры");
    }
    else
    {
        if (a < 1000 && a >= 100)
        {
            /*int a1 = a / 10;*/
            int a1 = a % 10;

            Console.WriteLine($"Третья цифра числа {a} = {a1}");

        }
        else
        {
            if (a < 10000 && a >= 1000)
            {
                int a1 = a % 100;
                int a2 = a1 / 10;

                Console.WriteLine($"Третья цифра числа {a} = {a2}");

            }
            else
            {
                if (a < 100000 && a >= 10000)
                {
                    int a1 = a % 1000;
                    int a2 = a1 / 100;

                    Console.WriteLine($"Третья цифра числа {a} = {a2}");

                }
            }
        }
    }
}