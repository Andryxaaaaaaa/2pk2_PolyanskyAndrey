using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цикл while
            double x = -4;
            double y;
            while(x <= 4)
            {
                //Условия для нашего примера
                x += 0.5;
                y = Math.Abs(x);
                Console.WriteLine(y);
            }
        }
    }
}
