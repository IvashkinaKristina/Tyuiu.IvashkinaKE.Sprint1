using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

// Написать программу, которая вычисляет математическое выражение
// по исходным значениям данных, вводимых пользователем.
//                 x                                                        
//     (      1   )          2                                             
// z = ( 1 + ---  ) - 12 * x   * y                                         
//     (     x^2  )     



namespace Tyuiu.IvashkinaKE.Sprint1.Task7.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Pow (1 + 1 / Math.Pow (x, 2) , x)  - 12 * Math.Pow(x, 2) * y , 3);
        }
    }
}

