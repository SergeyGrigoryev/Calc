/*
 * Класс Calculator
 * Позволяет вычислять значение арифметического выражения заданного в виде строки
*/

using System;
using System.Data;

namespace Calc
{
    /// <summary>
    /// Производит вычисление заданного выражения
    /// </summary>
    class Calc
    {
        /// <summary>
        /// Возвращает значение арифметического выражения. 
        /// </summary>              
        /// <remarks>
        /// Важно! При деление на ноль - результат: бесконечность!  
        /// </remarks>
        /// <see cref="http://msdn.microsoft.com/ru-ru/library/system.data.datatable.aspx"/>
        /// <see cref="http://msdn.microsoft.com/ru-ru/library/system.data.datatable.compute.aspx"/>
        /// <example>
        /// expression: "(2*3)/(1+2)*2-3"
        /// return: 1
        /// </example>
        /// <param name="expression">Строка, представляющая собой выражение</param>
        /// <returns>Результат выражения в виде строки</returns>
        public static string GetExpressionsResult(string expression)
        {
            var result = new DataTable().Compute(expression, null);

            return result.ToString();
        }
    }
}
