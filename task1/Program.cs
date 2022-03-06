Console.WriteLine("Введите число");
string numbers = Convert.ToString(Console.ReadLine());
int[] array = new int[numbers.Length];
for (int i=0; i < numbers.Length; i++)
{
array[i] = int.Parse(numbers[i].ToString());
}

Console.WriteLine("Введите порядковый номер отображаемого элемента числа: ");
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (array[index-1]);
