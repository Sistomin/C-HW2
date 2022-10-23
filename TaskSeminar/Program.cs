// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int num1 = num / 100;
int num2 = num % 10;
Console.WriteLine($"{num1}{num2}");

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//Console.WriteLine("Введите первое число: ");
//int num1 = Math.Abs((Convert.ToInt32(Console.ReadLine())));
//Console.WriteLine("Введите втрое число: ");
//int num2 = Math.Abs((Convert.ToInt32(Console.ReadLine())));
//if (num1 % num2 == 0 || num2 % num1 == 0)
//{
//  Console.WriteLine("Числа кратные");  
//}
//else
//{
    //if (num1 > num2)
    //{
    //Console.WriteLine("Числа не кратные, остаток от деления " + (num1 % num2));
    //}
    //else 
    //{
    //   Console.WriteLine("Числа не кратные, остаток от деления " + (num2 % num1)); 
    //}
//}

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//Console.WriteLine("Введите число: ");
//int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
//if (num % 7 == 0 && num % 23 == 0)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//Console.WriteLine("Введите первое число: ");
//int num1 = Math.Abs((Convert.ToInt32(Console.ReadLine())));
//Console.WriteLine("Введите втрое число: ");
//int num2 = Math.Abs((Convert.ToInt32(Console.ReadLine())));
//if (num1 == (num2 *num2) || num2 == (num1 *num1))
//{
//   Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}


