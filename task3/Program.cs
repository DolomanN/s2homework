Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 7;
int number3 = 23;

if (number1 % number2 == 0 & number1 % number3 == 0)
{
    Console.WriteLine("Кратно 7 и 23");
}
else
{
    Console.WriteLine("Не кратно");
}