//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

        string answer;

        do
        {
            Console.WriteLine("Узнай расстояние в 3D пространстве между двумя точками");

            Console.WriteLine("Введи координаты двух точек: ");
            Console.Write("A x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("A y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("A z1:");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("B z2:");
            int z2 = Convert.ToInt32(Console.ReadLine());

            // Найти расстояние через формулу Евклида
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            Console.WriteLine("Расстояние между точками: " + distance);

            Console.WriteLine("Хотите продолжить? (да/нет)");
            answer = Console.ReadLine();
        } while (answer.ToLower() == "да" || answer == "yes");

