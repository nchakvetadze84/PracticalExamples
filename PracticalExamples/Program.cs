using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PracticalExamples.DataAccess;

namespace PracticalExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //BoxingUnboxing.InitBoxingUnboxing();

            #region Events  & Delegate

            //var car = new Car() { Model = "Mazda" };
            //var carPublish = new CarPublish(); // publisher
            //var mail = new MailService(); // subscriber
            //carPublish.CarPublished += mail.OnCarPublished;
            //carPublish.Publish();

            #endregion Events  & Delegate

            #region  Anonymous Methods

            //DelegateHelper.Init();

            #endregion Anonymous Methods

            //var myInt = 8291;
            //Console.WriteLine(myInt.ReverseDigits());

            //Reflection.Init();

            //Linq.QueryStringWithOperators();

            #region  File IO

            //MyFile.SimpleFileIO();
            //MyFile.StreamWriterReaderApp();
            //MyFile.BinaryWriterReader();

            #endregion  File IO

            //WordCounter.Counter();

            Debug.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)} ManagedThreadId{Thread.CurrentThread.ManagedThreadId} {Environment.NewLine}");

            //Threading.Start();

            //var inst = new LinqJoin();
            //inst.Join();

            EFDemo.PrintBankInfo();

            Console.ReadLine();
        }
    }
}
