int numberA = new int();
Console.WriteLine("Введите число ");
numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0;
int index = 1;

while(index <= numberA)
{
    numberB = numberA-(numberA-index);
        if(numberB%2 == 0)
        {
            Console.Write(numberB+ " ");
        }
   index = index + 1;
}
