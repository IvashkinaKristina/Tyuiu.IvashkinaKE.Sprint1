using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvashkinaKE.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] a = value.Split(' ');
            string[] b = new string[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                char LastChar = a[i][a[i].Length - 1];
                b[i] = LastChar + a[i].Remove(a[i].Length - 1);
            }

            string NewString = string.Join(" ", b);

            return NewString;
        }
    }
}
