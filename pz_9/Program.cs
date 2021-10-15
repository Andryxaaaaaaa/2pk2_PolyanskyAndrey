using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;//объявление переменных
            int sum = 0;
            
            int[,] A = new int[3, 4];//создаем массив
            Console.WriteLine("Массив А: ");
            for (i = 0; i <= 2; i++)//пишем матрицу//создаем ее условия
            {
                for (j = 0; j <= 3; j++)
                    
                {
                    A[i, j] = i + 4 * j + 1;//выводимая матрица от 1 до 15 по столбцами и строкам
                    Console.Write(A[i, j] + " ");
                    sum += A[i, j];//чтобы найти сумму строк(складываются с предудущими)
                    
                }
                
                Console.WriteLine("=" + " " + sum + " " + " + предыдущая строка");//ответ
                

            }
            
            Console.ReadLine();
        }
    }
}
