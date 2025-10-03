using Tyuiu.DatskiyDE.Sprint3.Task0.V30.Lib;

namespace Tyuiu.DatskiyDE.Sprint3.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #3                                                              *");
            Console.WriteLine("* Тема: цикл for                                                         *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу используя цикл for,                                 *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                         *");
            Console.WriteLine("* p = ∏ₖ₌₁²⁰ ( k / sin(1)⁻¹⁰ )                                            *");
            Console.WriteLine("*                                                                        *");

        


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine("Старт = " + startValue);
            Console.WriteLine("Конец = " + stopValue);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
          
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(startValue, stopValue));
            
        }
    }
}
