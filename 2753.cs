using System;


namespace baekjoon
{
    class Program
    {
        static void Main(string[] args) 
        {
            int number = int.Parse(Console.ReadLine());

            if(number % 4 == 0)
            {
                if(number % 100 != 0 || number % 400 == 0)
                {
                    Console.WriteLine("1");
                }     
                else
                {
                    Console.WriteLine("0");
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
