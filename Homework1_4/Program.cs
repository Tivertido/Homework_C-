// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Чётные числа от 1 до {0}: ", N);
        int i = 2;
            while (i <= N)
            {
                Console.Write("{0} ", i);
                i += 2;
            }
    