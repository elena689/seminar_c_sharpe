int numberA = new int();
Console.WriteLine("Введите число ");
numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;
int index = 0;

while(index <= numberA*2)
{
        numberB = numberA-(2*numberA-index);
        Console.Write(numberB+ " ");
   index = index + 1;
}

