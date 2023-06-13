// Напишите программу на языке программирования C#, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b) {
            Console.WriteLine($"Максимальное число: {a}");
            Console.WriteLine($"Минимальное число: {b}");
        } else {
            Console.WriteLine($"Максимальное число: {b}");
            Console.WriteLine($"Минимальное число: {a}");
        }