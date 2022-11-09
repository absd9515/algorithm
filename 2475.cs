using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = int.Parse(s[2]);
            int D = int.Parse(s[3]);
            int E = int.Parse(s[4]);

            A *= A;
            B *= B;
            C *= C;
            D *= D;
            E *= E;

            Console.WriteLine((A+B+C+D+E) % 10);
        }
    }
}
