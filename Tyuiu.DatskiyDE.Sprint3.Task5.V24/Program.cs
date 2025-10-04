using Tyuiu.DatskiyDE.Sprint3.Task5.V24.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции:                                             *");
            Console.WriteLine("*       3     12                                                          *");
            Console.WriteLine("* y =   Z     Z   (x^k + 2) * sin(k), при x=2                             *");
            Console.WriteLine("*      i=1   k=1                                                          *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            int x = 2;

            Console.WriteLine("x = " + x);
            Console.WriteLine("i от " + startValue1 + " до " + stopValue1);
            Console.WriteLine("k от " + startValue2 + " до " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x,startValue1, stopValue1, startValue2, stopValue2);
            Console.WriteLine("Значение y = " + result);

            Console.ReadKey();
        }
    }
}