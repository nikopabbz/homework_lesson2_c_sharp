//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.Write("Введите трехзначное число > ");
string number = Console.ReadLine() ?? "0";
int count = int.Parse(number);

if (count > 99 && count < 1000)
{
    count = count / 10;
    int two_number = count % 10;
    System.Console.WriteLine(two_number);
}
else 
{ 
    System.Console.WriteLine("Вы ввели не трехзначное число");
}