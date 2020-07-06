using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace eCommerceSystem
{
    class Program
    {
        const int RETAILER_N = 5;
        public static MultiCellBuffer buffer = new MultiCellBuffer();
        static void Main(string[] args)
        {
            //print thread starting notification
            Console.WriteLine("Main thread started with initial chicken price $25...\n\n");
            
            ChickenFarm chicken = new ChickenFarm();
            //new Chicken Farm thread with name farmer
            Thread farmer = new Thread(new ThreadStart(() => chicken.OrderProcessingThread(buffer)))
            {
                Name = "farmer"
            };
            //Start the thread
            farmer.Start();

            Retailer store = new Retailer();
            //Generate the event
            ChickenFarm.priceCut += new priceCutEvent(store.OnSale);
            //Create 5 Retailers
            Thread[] retailers = new Thread[RETAILER_N];
            for(int i = 0; i < RETAILER_N; i++)
            {
                retailers[i] = new Thread(new ThreadStart(() => store.RetailerThread(buffer)));
                retailers[i].Name = (i + 1).ToString();
                retailers[i].Start();
            }
            farmer.Join();

            //print ending message
            Thread.Sleep(2000);
            Console.WriteLine("Main thread completed");
            Console.ReadKey();
        }
    }
}
