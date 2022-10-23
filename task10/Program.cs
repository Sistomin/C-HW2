// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзачное число: ");
int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
if (num > 99 && num <= 999)
{
   int result = num / 10;

   Console.Write("Вторая цифра: " + result % 10);
}
else
{
   Console.Write("Введенное число не трехзначное"); 
}