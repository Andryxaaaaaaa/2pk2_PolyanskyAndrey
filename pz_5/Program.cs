using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            Console.WriteLine("Задание 1\n");
            int a=20;
            int b=100;
            
            
            for (int i=a; i <= b; i+=5)
            {
                Console.WriteLine(i);
            }
            //Второе задание
            Console.WriteLine("Задание 2\n");

            char gaga='Е';
            for (var i = 0; i < 6; i++)
            {
                Console.WriteLine(gaga);
                gaga++;
            }
            //Третье задание
            Console.WriteLine("Задание 3\n");
            var j1 = '#';
            for (int i = 0; i != 9; i++)
            {
                for (int i0 = 0; i0 != 6; i0++)
                {
                    Console.Write(j1);
                }
                Console.WriteLine();
            }
            //Четверое задание
            Console.WriteLine("Задание 4\n");
            for (int i = 1; i != 105; i++)
            {
                var david = i % 5;
                if (david == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Пятое задание
            Console.WriteLine("Задание 5\n");
            
            for (int i = 3, j = 99; Math.Abs(i - j) != 4; i++, j--)
            {
                Console.WriteLine("{0} {1}", i, j);
            }
        }

    }
}
