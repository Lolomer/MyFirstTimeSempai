using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа");
        
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();

        if (input == null || input2 == null)
        {
            Console.WriteLine("Ошибка, введите число");
            return;
        }
        else 
        {
            int i1 = Convert.ToInt32(input);
            int i2 = Convert.ToInt32(input2);

            if (i2 > i1)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else if (i2 < i1)
            {
                Console.WriteLine("Второе число меньше первого");
            }
            else
            {
                Console.WriteLine("Они равны");
            }

        }


    }
}