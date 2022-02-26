int number_a = new int ();
int number_b = new int ();
Console.WriteLine("Введите первое число:");
number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
number_b = Convert.ToInt32(Console.ReadLine());
int number_c = number_a*number_a;
if (number_c==number_b)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else 
{
Console.WriteLine("Первое число не является квадратом второго числа");
}