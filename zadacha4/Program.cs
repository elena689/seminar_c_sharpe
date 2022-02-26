int number_a = new int ();
int number_b = new int ();
int number_c = new int ();
Console.WriteLine("Введите первое число:");
number_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
number_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
number_c = Convert.ToInt32(Console.ReadLine());

int max = number_a;

if(number_a > max ) max = number_a;
if(number_b > max ) max = number_b;
if(number_c > max ) max = number_c;

Console.Write("Максимальное число - ");
Console.WriteLine(max);