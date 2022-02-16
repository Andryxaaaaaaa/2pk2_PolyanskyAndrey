using System;

namespace pz_2_3
{
    class Subject
    {
        public string title;//Предмет
        public static int duration;//Количество часов(число)
        public string control;//Зачет или экзамен
        static int test = 0;//статический
        static int exam = 0;//статический

        public Subject(string a, int b, string c) //поля класса
        {
            //Конструктор с числовым и строковым типом переменных
            title = a;
            control = c;
            duration = b;

            //Добавил несколько строчек кода для пз 4
            //если количество часов вдруг не соответствует заданному промежутку
            Random rnd = new Random();
            if (duration < 30 || duration > 160)
            duration = rnd.Next(30, 160);

            //Проверка на зачет или экзамен
            if (control == "Зачет")
                test += 1;
            if (control == "Экзамен")
                exam += 1;

        }
        
        
        public void GetInfo() //метод,который выводит информацию о предмете
        {
            Console.WriteLine($"Предмет: {title}\nКоличество часов: {duration}\nЭкзамен/зачет: {control}\n");       
        }

        static void Main(string[] args)//Создаем 4 объекта с разными значениями
        {

            Subject Subject = new Subject("ЭВМ", 80 , "Экзамен");//1
            Subject.GetInfo();
            

            Subject Subject2 = new Subject("Дискретная Математика", 60, "Экзамен");//2
            Subject2.GetInfo();
            

            Subject Subject3 = new Subject("МДК_04.02", 55, "Экзамен");//3
            Subject3.GetInfo();
            

            Subject Subject4 = new Subject("Физра", 40, "Зачет");//4           
            Subject4.GetInfo();
            
            

            Console.WriteLine($"Зачетов :{test}\nЭкзаменов:{exam}")//вывод зачетов-экзаменов
        }
        
    }
}