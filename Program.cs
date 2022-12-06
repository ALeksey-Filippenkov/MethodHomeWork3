// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrome(int number2)
// {
//     if (number2 > 9999)
//     {
//         // 12321
//         int a = number2 / 10000;
//         int b = (number2 / 1000) % 10;
//         int c = (number2 % 100) / 10;
//         int d = number2 % 10;
//         if (a == d && b == c)
//             Console.WriteLine($"Да, число {number2} является палиндромом");
//         else
//             Console.WriteLine($"Нет, число {number2} не является палиндромом");
//     }
//     else
//         System.Console.WriteLine("Вы ввели не пятизначное число");
// }
// System.Console.WriteLine("Введите любое пятизначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrome(number);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Dist(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double d = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));
//     System.Console.WriteLine($"Расстояние: {Math.Round(d,2)}");
// }
// System.Console.Write("Введите координату X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координату Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Dist(x1, x2, y1, y2, z1, z2);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void TableOfCubes(int cube)
// {
// for (int i = 0; i < cube; i++)
// {
//     double result = Math.Pow(cube, 3);
//     System.Console.WriteLine(result);
// }
// }

// System.Console.WriteLine("Введите любое число. А программа покажет таблицу кубов чисел от 1 до N");
// int cube = Convert.ToInt32(Console.ReadLine());
// TableOfCubes (cube);


// void TableOfCubes(int Cube)
// {
//     if (Cube == 0)
//     {
//         for (int i = 1; i <= Cube; i++)
//         {
//             if (i < Cube)
//             {
//                 double result = Math.Pow(i, 3);
//                 System.Console.Write($"{result},");
//             }
//             else
//             {
//                 double result = Math.Pow(i, 3);
//                 System.Console.Write($"{result}");
//             }
//         }
//     }
//     else
//         Console.WriteLine("Куб числа 0 равняется 0");
// }
// System.Console.WriteLine("Введите любое число. А программа покажет таблицу кубов чисел от 1 до N");
// int cube = Convert.ToInt32(Console.ReadLine());
// TableOfCubes(cube);
// Console.ReadLine();