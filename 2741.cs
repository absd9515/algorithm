using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
   
        {
            int number = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            for(int i = 1; i<=number; i++)
            {
                result.Append($"{i}\n");
            }


            Console.Write(result);
         

            //for(int i =1; i <= int.Parse(s); i++)
            //{              
            //    Console.Write($"{i}\n");        
            //}
        }
    }
}
