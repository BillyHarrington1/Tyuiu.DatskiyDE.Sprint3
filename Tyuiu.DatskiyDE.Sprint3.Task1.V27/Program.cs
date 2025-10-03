using Tyuiu.DatskiyDE.Sprint3.Task1.V27.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task1.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: while                                                            *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл while,                               *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле,при n = 0,75            *");
            Console.WriteLine("*       5    1                                                           *");
            Console.WriteLine("* p =   П  (---)^3                                                       *");
            Console.WriteLine("*      k=1  n^k                                                          *");




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("Старт = " + startValue);
            Console.WriteLine("Конец = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

        }
    }
}
