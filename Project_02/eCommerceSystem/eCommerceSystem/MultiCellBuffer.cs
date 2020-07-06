using System;
using System.Diagnostics;
using System.Threading;

namespace eCommerceSystem
{
    class MultiCellBuffer
    {
        private const int SIZE = 3;
        string[] buffer = new string[SIZE];
        int head = 0;
        int tail = 0;
        public int counter = 0;
        Semaphore writer = new Semaphore(SIZE, SIZE);
        Semaphore reader = new Semaphore(SIZE, SIZE);

        public void setOneCell(string order)
        {
            writer.WaitOne();
            lock (this)
            {
                //if the buffer is full wait free space to add new one 
                while(counter == SIZE)
                {
                    Monitor.Wait(this);
                }
                buffer[tail] = order;
                tail = (tail + 1) % SIZE;
                counter++;
                writer.Release();
                Monitor.Pulse(this);
            }
        }

        public string getOneCell()
        {
            reader.WaitOne();
            lock (this)
            {
                //wait for a new element add to the buffer
                while(counter == 0)
                {
                    Monitor.Wait(this);
                }
                string ord = buffer[head];
                head = (head + 1) % SIZE;
                counter--;
                reader.Release();
                Monitor.Pulse(this);
                return ord;
            }
        }
    }
}
