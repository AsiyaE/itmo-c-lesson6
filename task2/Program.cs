using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача2 Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра
            string str = Console.ReadLine();
            string processedStr = str.Replace(" ", "").ToLower();
            int i = 0, j = processedStr.Length-1;
            bool isPalindrom = true;
            while ((isPalindrom) &&(i < j))
            {
                if (processedStr[i]!= processedStr[j])
                {
                    isPalindrom = false;
                }
                i++; j--;
            }

            Console.WriteLine("Является ли строка палиндромом? -  {0}", isPalindrom);
            #endregion

            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
