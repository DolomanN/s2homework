Console.WriteLine("Введите исходное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для проверки кратности: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number = 0;

if (number == (number1%number2))
{
    Console.WriteLine($"число {number1} является кратным для числа {number2}");
}

else
{
  Console.WriteLine($"число {number1} не является кратным для числа {number2}, остаток {number1%number2}");
}
