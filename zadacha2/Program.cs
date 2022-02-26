int number_a = new int ();
int number_b = new int ();
Console.WriteLine("Введите первое число:");
number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
number_b = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b)
{
    Console.WriteLine("Max = " +number_a+ ", Min = " +number_b);
}
else 
{
Console.WriteLine("Max = " +number_b+ ", Min = " +number_a);
}
