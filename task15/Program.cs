// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Программа проверки выходного дня");
Console.WriteLine("Введите порядковый номер дня недели:");

string? number = Console.ReadLine();
int numberCheck = int.Parse(number);

if (numberCheck > 5)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}