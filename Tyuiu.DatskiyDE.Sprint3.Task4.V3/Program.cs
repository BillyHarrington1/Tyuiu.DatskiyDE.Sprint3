using Tyuiu.DatskiyDE.Sprint3.Task4.V3.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: операторы continue и break                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить              *");
            Console.WriteLine("* значение функции y=(cos(x)+sin(x))/x                                    *");
            Console.WriteLine("* При x=0 прервать цикл. Полученные значения суммировать.                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало диапазона: " + startValue);
            Console.WriteLine("Конец диапазона: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine("Сумма значений функции: " + result);

            Console.ReadKey();
        }
    }
}