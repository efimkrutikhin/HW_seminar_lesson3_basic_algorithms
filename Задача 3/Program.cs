// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string answer = "";
int sqrt;
int num;

do
{
    Console.WriteLine("Введите ваше число: ");
        num = Convert.ToInt32(Console.ReadLine());

        if( num <= 0){
            Console.WriteLine("введено некорректное значение");
        } else{

        for (int i = 1; i <= num; i++)
        {
            sqrt = i * i * i;
            Console.WriteLine(sqrt);
        }
        }
    Console.WriteLine("Хотите продолжить?");
    answer = Console.ReadLine();
} while (answer.ToLower() == "yes" || answer.ToLower() == "да");
