using System;

namespace pz_2_3
{
    class Subject
    {
        public string title;//Предмет
        public int duration;//Количество часов(число)
        public string control;//Зачет или экзамен


        public Subject(string a, int b, string c) //поля класса
        {
            //Конструктор с числовым и строковым типом переменных
            title = a;
            duration = b;
            control = c;

        }

        public void GetInfo() //метод,который выводит информацию о предмете
        {
            Console.WriteLine($"Предмет: {title}\nКоличество часов: {duration}\nЭкзамен/зачет: {control}\n");
        }

        static void Main(string[] args)//Создаем 4 объекта с разными значениями
        {
            Subject Subject = new Subject("ЭВМ", 400 , "Экзамен");//1

            Subject.GetInfo();


            Subject Subject2 = new Subject("Дискретная Математика", 200, "Зачет");//2

            Subject2.GetInfo();


            Subject Subject3 = new Subject("МДК_04.02", 600, "Экзамен");//3

            Subject3.GetInfo();


            Subject Subject4 = new Subject("Физра", 140, "Зачет");//4

            Subject4.GetInfo();
        }
    }
}