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
        static void Main(string[] args)
        {
            string myApp = "MyApp";
            
            Mutex mutex = new Mutex(true, myApp, out newAppIsOpened);
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("App started!");
                Thread.Sleep(500);
                //if (newAppIsOpened)
                //{
                //    Environment.Exit(0);
                //}
            }
            Console.ReadKey();
            
        }
    }
}
