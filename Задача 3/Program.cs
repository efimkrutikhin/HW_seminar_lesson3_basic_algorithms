// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string answer;

do{

    Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sqrt;

for ( int i = 1; i <= num; i++){
    sqrt = i * 4;
    Console.WriteLine(sqrt);
}

Console.WriteLine("Хотите продолжить?");
answer = Console.ReadLine();
}while (answer.ToLower() == "yes" || answer.ToLower() == "да");
