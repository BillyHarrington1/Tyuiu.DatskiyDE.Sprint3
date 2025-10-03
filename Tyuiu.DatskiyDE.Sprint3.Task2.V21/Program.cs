using Tyuiu.DatskiyDE.Sprint3.Task2.V21.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: do...while                                                       *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #21                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл do...while,                          *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при x = 1.5                   *");
            Console.WriteLine("*       10   (    1     )^k                                              *");
            Console.WriteLine("* S =   Σ   ( -------- )                                                 *");
            Console.WriteLine("*      k=1   ( sin k + 2x^k )                                            *");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double value = 1.5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("x = " + value);
            Console.WriteLine("Start = " + startValue);
            Console.WriteLine("Stop = " + stopValue);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double result = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда S = " + result);

            Console.ReadKey();
        }
    }
}