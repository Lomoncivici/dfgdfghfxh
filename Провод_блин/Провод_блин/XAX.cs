using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Провод_блин
{
    internal class XAX
    {
        private static string a;
        public static string gg;
        public static void Faf()
        {
            Console.WriteLine("Введите путь до файла (вместе с названием).");
            Console.WriteLine("--------------------------------------------");
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            a = Console.ReadLine();
            gg = File.ReadAllText(a);
            
        }
        public static void FaF()
        {
            Console.WriteLine("Введите путь где сохронить файл (вместе с названием).");
            Console.WriteLine("--------------------------------------------");            
            a = Console.ReadLine();
            File.WriteAllText(a, gg);
            Console.Clear();
        }
    }
}
