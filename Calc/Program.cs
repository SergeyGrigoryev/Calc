/*
 * Класс Program
 * Содержит точку входа приложения
*/

using System;

namespace Calc
{
    class Program
    {
        /// <summary>
        /// Точка вхда приложения
        /// </summary>
        /// <param name="args">Строковый массив параметров программы</param>
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                Console.WriteLine(Calc.GetExpressionsResult(input));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("При вычислении выражения возникло исключение:\n{0}", e.Message);
                Console.WriteLine("Проверти правильность выражения");
                Console.ReadKey();
            }
        }
    }
}
