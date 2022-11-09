using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            for (int i = 1; i <= 9; i++)
            {
               
                Console.WriteLine($"{s} * {i} = {int.Parse(s)*i}");
                
            }
        }
    }
}
