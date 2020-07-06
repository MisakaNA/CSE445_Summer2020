using System;
using System.Diagnostics;
using System.Threading;

namespace eCommerceSystem
{
    public delegate void priceCutEvent(int pr);
    class ChickenFarm
    {
        private static Random rand = new Random();
        public static event priceCutEvent priceCut;
        private static int priceCutCounter = 0;
        private static int chickenPrice = 25;
        public int GetPrice() { return chickenPrice; }

        //pricing model to change the price
        public void PricingModel()
        {
            lock (this)
            {
                Thread.Sleep(2500);
                int price = rand.Next(12, 23);
                if (price < chickenPrice && price != -1 && priceCut != null)
                {
                    priceCut(price);
                    priceCutCounter++;

                    //debug message to calculate how many price cuts have been processed
                    Debug.WriteLine("{0} price cutted", priceCutCounter);
                }
                chickenPrice = price;
            }
        }

        //generate the order information
        public void OrderProcessing(OrderClass order)
        {
            if (order.CardNo >= 5000 && order.CardNo <= 7000)
            {
                const double taxRate = 0.08;
                const double handlingFee = 3;
                double total = (order.Amount * order.UnitPrice + handlingFee) * (1 + taxRate);
                //print out order confirm message
                Console.WriteLine("---- New Order Confirmed ----\n" +
                                  "From: Store {0}\n" +
                                  "Amount: {1}\n" +
                                  "Card Number: {2}\n" +
                                  "Chicken Unit Price: {3}\n" +
                                  "Total Cost: {4}\n" +
                                  "=========================================\n",
                                  order.SenderID, order.Amount, order.CardNo, order.UnitPrice, total);
            }
            else
            {
                Console.WriteLine("Invalid Card Number\n");
            }
        
        }

        //function on the server side to get encoded order from the buffer
        public void OrderProcessingThread(MultiCellBuffer buffer)
        {
            while (priceCutCounter < 10)
            {
                //if the buffer is not empty, takes out an order
                while (Program.buffer.counter != 0)
                {
                    if(Program.buffer.counter != 0)
                    {
                        string orderFromBuffer = buffer.getOneCell();
                        //send the order to decoder
                        DecodeOrder(orderFromBuffer);
                    }
                    
                }
                //change the price
                PricingModel();
            }

            //set price to -1 when meet the stopping condition
            if (priceCutCounter == 10)
            {
                chickenPrice = -1;
            }

            //confirm the remaining orders in the buffer, these orders are created before the last price cut
            while (Program.buffer.counter != 0)
            {
                if (Program.buffer.counter != 0)
                {
                    string orderFromBuffer = Program.buffer.getOneCell();
                    DecodeOrder(orderFromBuffer);
                }
            }
        }

        //function to decode the string to order object
        public void DecodeOrder(string order)
        {
            lock (this)
            {
                //split the string to get an array of order information
                string[] orderArr = order.Split(';');
                //create a new object
                var decodeOrder = new OrderClass()
                {
                    SenderID = orderArr[0],
                    CardNo = long.Parse(orderArr[1]),
                    Amount = int.Parse(orderArr[2]),
                    UnitPrice = int.Parse(orderArr[3])
                };
                
                //process the object and confirm the order
                Thread orderThread = new Thread(() => OrderProcessing(decodeOrder));
                orderThread.Start();
            }
        }


    }
}

    

