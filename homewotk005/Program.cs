// Задача 5 *: Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
Random rnd = new Random();
double count = 0.1;
for (; ; )
{
    int number1 = rnd.Next(1, 1000);
    System.Console.WriteLine(number1);
    if (number1 % count == 0)
    {
        System.Console.WriteLine($"Число {number1} кратно {count}");
        break;
    }
    count = number1;
}

