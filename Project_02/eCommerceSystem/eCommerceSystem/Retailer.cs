using System;
using System.Threading;

namespace eCommerceSystem
{
    class Retailer
    {
        private static Random rand = new Random();
        //set the initial price for order created before the first price cut event
        int currPrice = 25;

        //The function to start Retailer threads
        public void RetailerThread(MultiCellBuffer buffer)
        {
            ChickenFarm chicken = new ChickenFarm();
            
            //using loop to keep create the orders
            while(chicken.GetPrice() != -1)
            {
                Thread.Sleep(2000);
                //double check the price to avoid something happened during the sleep period
                if (chicken.GetPrice() != -1)
                {
                    //set random order properties
                    long cardNo = rand.Next(5000, 7000);
                    int amount = rand.Next(1, 5);
                    
                    //add the properties to the object
                    OrderClass newOrder = new OrderClass()
                    {
                        SenderID = Thread.CurrentThread.Name,
                        CardNo = cardNo,
                        Amount = amount,
                        UnitPrice = currPrice
                    };
                    
                    //print out order created message
                    Console.WriteLine("---- New Order Created ----\n" +
                                        "Sender ID: Store {0}\n" +
                                        "Card Number: {1}\n" +
                                        "Amount of Chickens Ordered: {2}\n" +
                                        "Current Unit Price: {3}\n" +
                                        "Order Received Time: {4}\n" +
                                        "=========================================\n",
                                        newOrder.SenderID, newOrder.CardNo, newOrder.Amount, newOrder.UnitPrice, DateTime.Now);
                    //encode the OrderClass object to string
                    EncodeOrder(newOrder);
                }    
            }
        }

        //function to encode order object to a string
        public void EncodeOrder(OrderClass order)
        {
            lock (this)
            {
                string str = order.SenderID + ";" + order.CardNo + ";" + order.Amount + ";" + order.UnitPrice;
                //send the encoded string to the buffer
                Program.buffer.setOneCell(str);
            }
        }

        //Event handler method
        public void OnSale(int price)
        {
            Console.WriteLine("Thread {0}: chickens are on sale: as low as ${1} each at time {2}\n\n", Thread.CurrentThread.Name, price, DateTime.Now);
            //hold the price when price cut event happens
            currPrice = price;
        }
    }
}
