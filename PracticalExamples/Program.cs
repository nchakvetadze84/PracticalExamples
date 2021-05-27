using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Linq.Start();

            #region  File IO

            MyFile.SimpleFileIO();
            MyFile.StreamWriterReaderApp();
            MyFile.BinaryWriterReader();

            #endregion  File IO



            Console.ReadLine();
        }
    }
}
