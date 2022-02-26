int number_a = new int ();
int number_b = new int ();

Console.WriteLine("Введите число:");
number_a = Convert.ToInt32(Console.ReadLine());
number_b = number_a*number_a;
Console.WriteLine("Квадрат числа " +number_a+ " равен " +number_b);
