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
            while(x <= 4)//Но, в консольке у меня выводится конечное число 4.5,так что я думаю,что можно прописать код:  while(x <= 3.5)
            {
                //Условия для нашего примера
                x += 0.5;
                y = Math.Abs(x);
                Console.WriteLine(y);
            }
        }
    }
}
