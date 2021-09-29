using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цикл while
            double x = -4.5;//Либо -4 по условию из примера
            double y;
            while(x <= 3.5)//Либо 4 по условию из примера
            {
                //Условия для нашего примера
                x += 0.5;
                y = Math.Abs(x);
                Console.WriteLine(y);
            }
        }
    }
}
