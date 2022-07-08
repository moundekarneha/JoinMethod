using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JoinMethod
{
    internal class Program
    {
        static void Test1()
        {
            for(int i=1; i < 5; i++)
            {
                Console.WriteLine("Test 1 :"+i);
             
            }
            Thread.Sleep(5000);
            Console.WriteLine("Test 1 Thread Exiting");
        }

        static void Test2()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Test 2 :" + i);
            }
            Console.WriteLine("Test 2 Thread Exiting");
        }

        static void Test3()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Test 3 :" + i);
            }
            Console.WriteLine("Test 3 Thread Exiting");
        }
        static void Main(string[] args)
        {
            //should not allow main thread to exit till all other thread exits - so use join
            Console.WriteLine("Main Thread Started:");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();

            //main thread will not exit till all child thread completed their jobs - join - join is calling by join
            t1.Join(3000); //main thread will wait for only 3 sec if we give time period
            t2.Join();
            t3.Join();
            Console.WriteLine("Main Thread Exiting");






            Console.ReadLine();
        }
    }
}
