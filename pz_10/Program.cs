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
//Вариант 20.
            //1 этап.
            char[][] A = new char[4][];
            Random rnd = new Random();// рандом.
            var last = new char[4];
            var max = new char[4];
            int iter = 0;
            int gaga = 0;
            for (int i = 0; i < 4; i++)
            {
                A[i] = new char[rnd.Next(10, 15)]; 

                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = (char)rnd.Next(100);
                  
                }
            }

            //2 этап.
            //Выводим массив.
            foreach (char[] item in A)
            {
                foreach (char i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //3 этап.
            //Находим последние значения.
            for (int i = 0; i < 4; i++)
            {
                last[i] = A[i][A[i].Length - 1];
            }

            foreach (var i in last)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //4 этап.
            //Находим максимальные значения.
            for (int i = 0; i < 4; i++)
            {
                max[i] = A[i].Max();
            }
            //Выводим значения.
            foreach (var i in max)
            {
                Console.Write(i + " ");
            }
            //5 этап.
            //Меняем местами значения.
            for (int i = 0; i < 4; i++)
            {
                A[i] = new char[rnd.Next(10, 15)];

                for (int j = 0; j < A[i].Length; j++)
                {
                    iter = j;
                    char temp = A[i][0];
                    A[i][0] = A[i][iter];
                    A[i][iter] = temp;
                    //Выводим.
                    for ( j = 0; j < A[i].Length; j++)
                        Console.Write(A[i][j] + "   ");
                    Console.WriteLine();


                }
            }

            //Завершение.
            Console.WriteLine();
        }



    }
}