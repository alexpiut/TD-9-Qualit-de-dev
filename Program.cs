using System;

namespace TD_9_Qualité_de_dev
{
    class Program
    {
        public static int AdditionDeuxEntiers (int nb1, int nb2)
        {
            int res;
            res = nb1 + nb2;
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AdditionDeuxEntiers(2, 3));
        }
    }
}
