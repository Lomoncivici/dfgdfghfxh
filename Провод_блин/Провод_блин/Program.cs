namespace Провод_блин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Da newkek = new Da(19, "gthtdtn");
            Console.WriteLine(newkek.Kek);
            newkek.Kek = 20;
            Console.WriteLine(newkek.Kek);*/
            while (true)
            {
                /*C: \Users\SystemX\Desktop*/
                XAX.Faf();
                Console.WriteLine("нажмите t для редоктирования");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    Edit.TXT();
                }
                else if (key.Key != ConsoleKey.T)
                {
                    XAX.FaF();
                }
            }
        }
    }
}