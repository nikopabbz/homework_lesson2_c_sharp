// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.Write("Введите число > ");
string number = Console.ReadLine() ?? "0";
int count = int.Parse(number);

if (count > 0 && count < 8)
{
    if (count > 0 && count < 6)
    {
        System.Console.WriteLine("Данный день не выходной");
    }
    else
    {
        System.Console.WriteLine("Данный день выходной");
    }
}
else 
{ 
    System.Console.WriteLine("Число не соответствует дню недели");
}