// Задача 5 *: Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
System.Console.Write("Введите число > ");
string number = Console.ReadLine() ?? "0";
int count = int.Parse(number);
Random rnd = new Random();
for (; ; )
{
    int number1 = rnd.Next(1, 1000);
    System.Console.WriteLine(number1);
    if (number1 % count == 0)
    {
        System.Console.WriteLine($"Число {number1} кратно {count}");
        break;
    }
}

