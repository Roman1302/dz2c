// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.WriteLine("Программа вывода третьей цифры");
Console.WriteLine("Введите число: ");

string? number = Console.ReadLine();
int numberCheck = int.Parse(number);
if (numberCheck > 99)
{
    Console.WriteLine(number[2]);
}
else if (numberCheck < -99)
{
    Console.WriteLine(number[3]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}