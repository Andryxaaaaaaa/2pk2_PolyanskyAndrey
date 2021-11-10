using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_10
{
    class Program
    {   
        static void Main(string[] args)
        {
            //16 вариант
            char[][] zubArr = new char[5][]; //объявляю первое измерени
            Random rnd = new Random();
            var lastItemsArray = new char[5];
            var maxItemsArray = new char[5];
            for (int i = 0; i < 5; i++)
            {
                zubArr[i] = new char[rnd.Next(6, 15)]; //второе измерение

                for (int j = 0; j < zubArr[i].Length; j++)
                {
                    zubArr[i][j] = (char)rnd.Next(100);
                }
            }

            foreach (char[] item in zubArr)
            {
                foreach (char i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                lastItemsArray[i] = zubArr[i][zubArr[i].Length - 1];
            }

            foreach (var i in lastItemsArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                maxItemsArray[i] = zubArr[i].Max();
            }

            foreach (var i in maxItemsArray)
            {
                Console.Write(i + " ");
            }
            // последние задания не получилось сделать
            Console.WriteLine();
            Console.ReadLine();
        }



    }
}