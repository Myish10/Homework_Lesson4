// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Exponentiation(int num, int pow)
{
    int expon = num;
    for (int i = 1; i < pow; i++)
    {
        expon = expon * num;
    }
    return expon;
}

int number = InputNum("Введите целое число: ");
int power = InputNum("Введите натуральное число");
int exponent = Exponentiation(number, power);
if (power <= 0) Console.WriteLine("Вы ввели не натуральное число, попробуйте еще раз :)");
else Console.WriteLine(exponent);