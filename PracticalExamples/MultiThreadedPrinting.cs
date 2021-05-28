﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticalExamples
{
    #region Printer helper class
    public class Printer
    {
        // Lock token.
        private object threadLock = new object();

        public void PrintNumbers()
        {
            lock (threadLock)
            {
                // Display Thread info.
                Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

                // Print out numbers.
                Console.Write("Your numbers: ");
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100 * r.Next(5));
                    Console.Write("{0}, ", i);
                }
                Console.WriteLine();
            }
        }
    }
    #endregion

    class Starter
    {
        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static object threadLock = new object();

        static void Start(string[] args)
        {
            int counter = 0;
            Console.WriteLine("*****Synchronizing Threads *****\n");

            Printer p = new Printer();

            // Make 10 threads that are all pointing to the same
            // method on the same object.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(p.PrintNumbers);
                threads[i].Name = string.Format("Worker thread #{0}", i);
            }
            //

            // Now start each one.
            foreach (Thread t in threads)
                t.Start();

            Parallel.For(1, 10, i =>
            {
                Debug.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} ManagedThreadId {Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");

                if (isPrime(i))
                {
                    lock (threadLock)
                    {
                        counter++;
                    }
                }
            });


            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
