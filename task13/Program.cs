// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int num = Math.Abs((Convert.ToInt32(Console.ReadLine())));
if (num < 100)
{
    Console.WriteLine($"В числе {num} нет третей цифры!");
}
else
{
    string numText = Convert.ToString(num);
    Console.WriteLine($"Третья цифра в числе {num} -> {numText[2]}");
}