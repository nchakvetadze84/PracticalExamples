using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticalExamples
{
    class Threading
    {
        public static void Start()
        {
            //F1();
            //F2();


            Debug.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} ManagedThreadId{Thread.CurrentThread.ManagedThreadId} {Environment.NewLine}");

            var obj1 = new Thread(F1);

            var obj2 = new Thread(F2);
            
            obj1.Start();
            obj2.Start();



            //Console.WriteLine("End");

            //Parallel.For(1, 10, i =>
            //{
            //    Debug.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} ManagedThreadId {Thread.CurrentThread.ManagedThreadId}{Environment.NewLine}");


            //});
        }

        public static void F1()
        {
            Debug.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} ManagedThreadId{Thread.CurrentThread.ManagedThreadId} {Environment.NewLine}");

            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("F1 -"  + i);
            }
        }

        public static void F2()
        {
            Debug.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} ManagedThreadId{Thread.CurrentThread.ManagedThreadId} {Environment.NewLine}");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("F2 -" + i);
            }
        }

        public static void BackOrFore()
        {
            Console.WriteLine("1");

            Console.ReadLine();

            Console.WriteLine("2");

        }
    }
}
