// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число обозначающие порядковый день недели (от 1 до 7): ");
int day = Math.Abs((Convert.ToInt32(Console.ReadLine())));
if (day >= 1 && day <= 7)
{
if (day == 6 || day == 7)
{
    Console.WriteLine("Да, это выходной!");
}
else
{
    Console.WriteLine("Нет, это будний день!");
}
}
else
{
   Console.WriteLine("Число нужно вводить от 1 до 7!"); 
}