using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача1 Найти самое длинное слово в строке

            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = "";

            foreach(string s in strArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            
            Console.WriteLine("Слово максимальной длины  {0}", max);
            #endregion

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
