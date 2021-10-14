using System;


namespace pz_8
{
    class Program 
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do//Добавим цикл,чтобы после выполнения программы,можно было сгенироровать числа заного
            {
                Random rnd = new Random();//Наполним массив рандомно
                int[] A = new int[20];
                A[0] = rnd.Next(0, 21);
                for (int i = 1; i < 20;)
                {
                    int num = rnd.Next(0, 21);
                    int j;
                    //Ищем найденое совпадание
                    for (j = 0; j < i; j++)
                    {
                        if (num == A[j])
                            break; //Совпадение найдено
                    }
                    if (j == i)
                    { //Ищем ненайденое совпадание
                        A[i] = num;
                        i++;
                    }
                }
                Console.Write("Массивы которые не повторяются\n");
                for (int i = 0; i < 20; i++)//Выводим значения
                {

                    Console.Write(A[i] + " ");

                }
                //Выполнение цикла
                Console.WriteLine("\nНажмите Enter,чтобы сгенерировать новые числа ");
                keyInfo = Console.ReadKey(true);

            }
            while (keyInfo.Key == ConsoleKey.Enter);//При нажатии кнопки Enter программа выполнсяется заного




        }
    }
}
