// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string answer;
int sqrt;
int num;

do
{
    try
    {
    Console.WriteLine("Введите ваше число: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            sqrt = i * 4;
            Console.WriteLine(sqrt);
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Ошибка: Введено некорректное значение");
    }

    Console.WriteLine("Хотите продолжить?");
    answer = Console.ReadLine();
} while (answer.ToLower() == "yes" || answer.ToLower() == "да");
