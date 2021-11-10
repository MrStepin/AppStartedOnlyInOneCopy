using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AppStartedOnlyInOneCopy
{
    class Program
    {
        static bool newAppIsOpened;
        static string myApp = "MyApp";

        static void Main(string[] args)
        {          
            Mutex mutex = new Mutex(true, myApp, out newAppIsOpened);
            if (!newAppIsOpened)
            {
                return;
            }
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("App started!");
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
