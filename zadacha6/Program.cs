int number_a = new int ();

Console.WriteLine("Введите число:");
number_a = Convert.ToInt32(Console.ReadLine());

if(number_a%2 == 0)
{
    Console.WriteLine(number_a+ " - чётное число");
}
else
{
    Console.WriteLine(number_a+ " - нечётное число");
}