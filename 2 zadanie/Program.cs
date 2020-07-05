using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            string[] s = text.Split('!', '.', '?');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1);
                else s[i] = s[i].ToUpper();

                string.Join(" ", s);
                Console.WriteLine("Отредактированный текст:" + s[i]);
                Console.ReadKey();
            }
        }
    }
}














