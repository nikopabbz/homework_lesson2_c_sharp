// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.Write("Введите число > ");
string number = Console.ReadLine() ?? "0";
int count = int.Parse(number);
int number3 = count % 10;
if (count < 100)
{
    System.Console.WriteLine("Третьей цифры нету");
}
else
{
    System.Console.WriteLine(number3);
}