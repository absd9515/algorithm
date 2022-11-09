using System;


namespace baekjoon
{
    class Program
    {
        static void Main(string[] args) 
        {
            int number = int.Parse(Console.ReadLine());

            int A = 100;
            int B = 89;
            int C = 79;
            int D = 70;
            int E = 60;


            if(number > B)
            {
                Console.WriteLine("A");
            }
            else if(number > C)
            {
                Console.WriteLine("B");
            }
            else if (number >= D)
            {
                Console.WriteLine("C");
            }
            else if (number >= E)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
