using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = " ";
            foreach(char i in str1)
            {
                if(char.ToUpper(i) == i)
                {
                    str2 += "_" + char.ToLower(i);
                }
                else
                {
                    str2 += i;
                }
                Console.WriteLine(str2);
            }
        }
    }
}
