using System;

namespace lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
 
                //2.1 средний уровень - 8 вариант
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                if (n % 3 != 0 && n % 7 == 0 && n % 10 == 0)
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");       
                
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно переменную");
            }
        }
    }
}
